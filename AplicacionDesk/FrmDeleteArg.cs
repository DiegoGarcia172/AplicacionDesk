﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionDesk
{
    public partial class FrmDeleteArg : Form
    {
        public FrmDeleteArg()
        {
            InitializeComponent();
        }
        private async Task<bool> EjecutarAccionApi(string url, HttpMethod metodo, string token, string jsonBody = null)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
                    HttpRequestMessage request = new HttpRequestMessage(metodo, url);
                    if (!string.IsNullOrEmpty(jsonBody))
                    {
                        request.Content = new StringContent(jsonBody, System.Text.Encoding.UTF8, "application/json");
                    }
                    HttpResponseMessage response = await client.SendAsync(request);
                    if (response.IsSuccessStatusCode)
                    {
                        return true;
                    }
                    else
                    {
                        string errorBody = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Error: {response.StatusCode} - {errorBody}");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
                return false;
            }
        }
        private async Task EjecutarAccion1(string url, bool esLogin)
        {
            string nombre = txtNombre.Text;
            string correo = txtCorreo.Text;
            string clave = txtClave.Text;
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(clave))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            var datos = new
            {
                nombre = nombre,
                correo = correo,
                clave = clave
            };
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string json = JsonConvert.SerializeObject(datos);
                    StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(url, content);
                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        if (esLogin)
                        {
                            var respuesta = JsonConvert.DeserializeObject<dynamic>(responseBody);
                            string token = respuesta?.token;
                            if (!string.IsNullOrEmpty(token))
                            {
                                txtToken.Text = token;
                                MessageBox.Show("Login exitoso.");
                            }
                            else
                            {
                                MessageBox.Show("No se pudo obtener el token.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Registro exitoso.");
                        }
                    }
                    else
                    {
                        string errorBody = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Error: {response.StatusCode} - {errorBody}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }
        private async void btnObtenerToken_Click(object sender, EventArgs e)
        {
            string urlLogin = "https://localhost:7140/api/Acceso/Login";
            await EjecutarAccion1(urlLogin, true);
        }
        private async void btnRegistrar_Click(object sender, EventArgs e)
        {
            string urlRegistro = "https://localhost:7140/api/Acceso/Registrar";
            await EjecutarAccion1(urlRegistro, false);
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            FrmMenu frm = new FrmMenu();
            frm.Show();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private async void btnConsutlar_Click_1(object sender, EventArgs e)
        {
            string apiUrl = txtUrl.Text; 
            string id = txtID.Text;
            string token = txtToken.Text;
            if (string.IsNullOrWhiteSpace(apiUrl))
            {
                MessageBox.Show("Por favor, ingrese una URL válida.");
                return;
            }
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Por favor, ingrese un ID válido.");
                return;
            }
            if (string.IsNullOrWhiteSpace(token))
            {
                MessageBox.Show("Por favor, ingrese un token válido.");
                return;
            }
            string fullUrl = $"{apiUrl}/{id}";
            bool success = await EjecutarAccionApi(fullUrl, HttpMethod.Delete, token);
            if (success)
            {
                MessageBox.Show("Eliminado exitosamente.");
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el registro.");
            }
        }
    }
}

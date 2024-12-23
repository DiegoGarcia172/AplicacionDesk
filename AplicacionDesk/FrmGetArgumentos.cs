﻿using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Text;

namespace AplicacionDesk
{
    public partial class FrmGetArgumentos : Form
    {
        public FrmGetArgumentos()
        {
            InitializeComponent();
        }
        private DataTable ConvertSingleJsonObject(string json)
        {
            try
            {
                var jsonObject = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);
                DataTable dataTable = new DataTable();
                foreach (var key in jsonObject.Keys)
                {
                    dataTable.Columns.Add(key);
                }
                var row = dataTable.NewRow();
                foreach (var key in jsonObject.Keys)
                {
                    row[key] = jsonObject[key] ?? DBNull.Value;
                }
                dataTable.Rows.Add(row);
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar los datos: {ex.Message}");
                return null;
            }
        }
        private async void btnConsutlar_Click(object sender, EventArgs e)
        {
            string apiUrl = txtUrl.Text;
            string token = txtToken.Text;
            if (string.IsNullOrWhiteSpace(apiUrl))
            {
                MessageBox.Show("Por favor, ingrese una URL válida.");
                return;
            }
            if (string.IsNullOrWhiteSpace(token))
            {
                MessageBox.Show("Por favor, ingrese un token válido.");
                return;
            }
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(responseBody);
                    DataTable dataTable = ConvertSingleJsonObject(responseBody);
                    if (dataTable != null)
                    {
                        dgvDatos.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("No se pudieron cargar los datos.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }
        private async Task EjecutarAccion(string url, bool esLogin)
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
            await EjecutarAccion(urlLogin, true);
        }
        private async void btnRegistrar_Click(object sender, EventArgs e)
        {
            string urlRegistro = "https://localhost:7140/api/Acceso/Registrar";
            await EjecutarAccion(urlRegistro, false);
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
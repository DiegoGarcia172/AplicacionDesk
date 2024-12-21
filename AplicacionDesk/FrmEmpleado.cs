using Newtonsoft.Json;
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
    public partial class FrmEmpleado : Form
    {
        public FrmEmpleado()
        {
            InitializeComponent();
        }
        private async Task EjecutarAccionLoginRegistro(string url, bool esLogin)
        {
            string nombre = txtNombre.Text;
            string correo = txtCorreo.Text;
            string clave = txtClave.Text;
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(clave))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            var datos = new { nombre, correo, clave };
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
            await EjecutarAccionLoginRegistro(urlLogin, true);
        }
        private async Task<bool> EjecutarPostPut(string url, string token, object datos, HttpMethod metodo)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
                    string jsonBody = JsonConvert.SerializeObject(datos);
                    HttpRequestMessage request = new HttpRequestMessage(metodo, url)
                    {
                        Content = new StringContent(jsonBody, Encoding.UTF8, "application/json")
                    };
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
        private async void btnPut_Click(object sender, EventArgs e)
        {
            string apiUrl = txtUrl.Text;
            string token = txtToken.Text;
            string id = txtid.Text;
            if (string.IsNullOrWhiteSpace(apiUrl) || string.IsNullOrWhiteSpace(token) || string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Por favor, ingrese una URL válida, el token y el ID.");
                return;
            }
            if (!int.TryParse(id, out var idValue))
            {
                MessageBox.Show("El ID debe ser un número válido.");
                return;
            }
            var datos = new
            {
                id = idValue,
                nombre = txtName.Text,
                apellido_Paterno = txtApellidoPaterno.Text,
                apellido_Materno = txtApellidoMaterno.Text,
                puesto = txtPuesto.Text,
                id_departamento = int.TryParse(txtIdDepartamento.Text, out var idDepartamentoValue) ? idDepartamentoValue : 0
            };
            string fullUrl = $"{apiUrl}/{idValue}";
            bool success = await EjecutarPostPut(fullUrl, token, datos, HttpMethod.Put);
            MessageBox.Show(success ? "Empleado actualizado exitosamente." : "No se pudo actualizar el empleado.");
        }
        private async void btnPost_Click(object sender, EventArgs e)
        {
            string apiUrl = txtUrl.Text;
            string token = txtToken.Text;

            if (string.IsNullOrWhiteSpace(apiUrl) || string.IsNullOrWhiteSpace(token))
            {
                MessageBox.Show("Por favor, ingrese una URL válida y el token.");
                return;
            }
            var datos = new
            {
                id = 0,
                nombre = txtName.Text,
                apellido_Paterno = txtApellidoPaterno.Text,
                apellido_Materno = txtApellidoMaterno.Text,
                puesto = txtPuesto.Text,
                id_departamento = int.TryParse(txtIdDepartamento.Text, out var idDepartamentoValue) ? idDepartamentoValue : 0
            };
            bool success = await EjecutarPostPut(apiUrl, token, datos, HttpMethod.Post);
            MessageBox.Show(success ? "Empleado creado exitosamente." : "No se pudo crear el empleado.");
        }
        private async void btnRegistrar_Click(object sender, EventArgs e)
        {
            string urlRegistro = "https://localhost:7140/api/Acceso/Registrar";
            await EjecutarAccionLoginRegistro(urlRegistro, false);
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
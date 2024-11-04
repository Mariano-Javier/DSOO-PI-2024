using DSOO_PI_ComC_Grupo12.Helpers;
using DSOO_PI_ComC_Grupo12.Models;
using DSOO_PI_ComC_Grupo12.Repositories;
using System;
using System.Windows.Forms;

namespace DSOO_PI_ComC_Grupo12.Controllers
{
    public class RegistrarClienteController
    {
        private readonly ClienteRepository _clienteRepository;
        private bool _esSocio = true;
        private bool _esApto = true;

        public RegistrarClienteController()
        {
            _clienteRepository = new ClienteRepository();
        }

        public void Limpiar(TextBox txtNombre, TextBox txtApellido, TextBox txtDNI, TextBox txtEmail, TextBox txtTelefono, DateTimePicker dateFechaNac, RadioButton radioSocio, RadioButton radioAptoFisicoSi)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDNI.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            dateFechaNac.Value = DateTime.Now;
            ResetearRadioButtons(radioSocio, radioAptoFisicoSi);
        }

        private void ResetearRadioButtons(RadioButton radioSocio, RadioButton radioAptoFisicoSi)
        {
            // Restablecer el estado del botón de "Socio" a marcado
            radioSocio.Checked = true;
            radioAptoFisicoSi.Checked = true;

            // Restablecer el valor de la variable esSocio a su valor original
            _esSocio = true;
            _esApto = true;
        }

        public bool CamposVacios(TextBox txtNombre, TextBox txtApellido, TextBox txtDNI, TextBox txtEmail, TextBox txtTelefono)
        {
            // Lista de controles a validar
            string[] campos = { txtNombre.Text, txtApellido.Text, txtDNI.Text, txtEmail.Text, txtTelefono.Text };

            // Verifica si algún campo está vacío o con espacios
            return Validaciones.CamposVacios(campos);
        }

        public bool CamposValidos(TextBox txtNombre, TextBox txtApellido, TextBox txtDNI, TextBox txtEmail, TextBox txtTelefono)
        {
            if (CamposVacios(txtNombre, txtApellido, txtDNI, txtEmail, txtTelefono))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return false;
            }
            if (!Validaciones.EmailValido(txtEmail.Text))
            {
                MessageBox.Show("El correo electrónico no tiene un formato válido.");
                return false;
            }
            return true;
        }

        public void RegistrarCliente(TextBox txtNombre, TextBox txtApellido, TextBox txtDNI, TextBox txtEmail, TextBox txtTelefono, DateTimePicker dateFechaNac, RadioButton radioSocio, RadioButton radioAptoFisicoSi)
        {
            // Creamos un objeto Cliente con los datos del formulario
            Cliente nuevoCliente = new Cliente(
                id: 0,  // Este valor lo maneja la base de datos, es autoincremental.
                nombre: txtNombre.Text,
                apellido: txtApellido.Text,
                dni: txtDNI.Text,
                mail: txtEmail.Text,
                telefono: txtTelefono.Text,
                fechaNacimiento: dateFechaNac.Value,
                esSocio: _esSocio,
                esApto: _esApto
            );

            try
            {
                // Verifica si ya existe un usuario con el mismo DNI
                if (_clienteRepository.ExisteDni(nuevoCliente.Dni))
                {
                    MessageBox.Show("Ya existe un cliente registrado con este DNI.");
                    return;
                }

                // Registra el cliente
                long ultimoId = _clienteRepository.RegistrarCliente(nuevoCliente);
                if (ultimoId > 0)
                {
                    MessageBox.Show($"Cliente registrado exitosamente. El ID del cliente es {ultimoId}.");
                    Limpiar(txtNombre, txtApellido, txtDNI, txtEmail, txtTelefono, dateFechaNac, radioSocio, radioAptoFisicoSi);
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al registrar el cliente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el cliente: " + ex.Message);
            }
        }

        public void SetEsSocio(bool esSocio)
        {
            _esSocio = esSocio;
        }

        public void SetEsApto(bool esApto)
        {
            _esApto = esApto;
        }
    }
}

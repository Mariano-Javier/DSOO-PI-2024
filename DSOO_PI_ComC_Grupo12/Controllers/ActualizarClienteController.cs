using DSOO_PI_ComC_Grupo12.Helpers;
using DSOO_PI_ComC_Grupo12.Models;
using DSOO_PI_ComC_Grupo12.Repositories;
using System;
using System.Windows.Forms;

namespace DSOO_PI_ComC_Grupo12.Controllers
{
    public class ActualizarClienteController
    {
        private readonly ClienteRepository _clienteRepository;

        public ActualizarClienteController()
        {
            _clienteRepository = new ClienteRepository();
        }

        public void Limpiar(TextBox txtNombre, TextBox txtApellido, TextBox txtDNI, TextBox txtEmail, TextBox txtTelefono, DateTimePicker dateFechaNac, TextBox txtClienteIDoDNI, RadioButton radioSocio, RadioButton radioAptoFisicoSi)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDNI.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            dateFechaNac.Value = DateTime.Now;
            txtClienteIDoDNI.Text = string.Empty;
            ResetearRadioButtons(radioSocio, radioAptoFisicoSi);
        }

        public void ResetearRadioButtons(RadioButton radioSocio, RadioButton radioAptoFisicoSi)
        {
            radioSocio.Checked = true;
            radioAptoFisicoSi.Checked = true;
        }

        public bool CamposVacios(TextBox txtNombre, TextBox txtApellido, TextBox txtDNI, TextBox txtEmail, TextBox txtTelefono)
        {
            string[] campos = { txtNombre.Text, txtApellido.Text, txtDNI.Text, txtEmail.Text, txtTelefono.Text };
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

        public Cliente? BuscarCliente(string input, bool esId)
        {
            if (esId)
            {
                if (int.TryParse(input, out int clienteId))
                {
                    return _clienteRepository.BuscarClientePorId(clienteId);
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return _clienteRepository.BuscarClientePorDni(input);
            }
        }

        public bool ActualizarCliente(Cliente cliente)
        {
            return _clienteRepository.ActualizarCliente(cliente);
        }
    }
}

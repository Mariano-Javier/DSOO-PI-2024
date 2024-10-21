using DSOO_PI_ComC_Grupo12.Helpers;
using DSOO_PI_ComC_Grupo12.Interfaces;
using DSOO_PI_ComC_Grupo12.Models;
using DSOO_PI_ComC_Grupo12.Repositories;
using System;
using System.Windows.Forms;

namespace DSOO_PI_ComC_Grupo12.Views
{
    public partial class RegistrarCliente : Form, IRegistrar
    {
        public bool esSocio = true;
        public bool esApto = true;
        private readonly ClienteRepository _clienteRepository;

        public RegistrarCliente()
        {
            InitializeComponent();
            _clienteRepository = new ClienteRepository();
        }

        //Metodos de ayuda
        public void Limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDNI.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            dateFechaNac.Value = DateTime.Now;
            ResetearRadioButtons();
        }

        private void ResetearRadioButtons()
        {
            // Restablecer el estado del botón de "Socio" a marcado
            radioSocio.Checked = true;
            radioAptoFisicoSi.Checked = true;

            // Restablecer el valor de la variable esSocio a su valor original
            esSocio = true;
            esApto = true;
        }

        // Verifica si hay campos vacíos
        public bool CamposVacios()
        {
            // Lista de controles a validar
            string[] campos = { txtNombre.Text, txtApellido.Text, txtDNI.Text, txtEmail.Text, txtTelefono.Text };

            // Verifica si algún campo está vacío o con espacios
            return Validaciones.CamposVacios(campos);
        }

        // Valida todos los campos
        public bool CamposValidos()
        {
            if (CamposVacios())
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

        //fin metodos de ayuda
        public void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        //Radio buttons
        private void radioSocio_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSocio.Checked)
            {
                esSocio = true;
            }
        }

        private void Radio_no_socio_CheckedChanged(object sender, EventArgs e)
        {
            if (Radio_no_socio.Checked)
            {
                esSocio = false;
            }
        }

        private void radioAptoFisicoSi_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAptoFisicoSi.Checked)
            {
                esApto = true;
            }
        }

        private void radioAptoFisicoNo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAptoFisicoNo.Checked)
            {
                esApto = false;
            }
        }
        //fin radio buttons

        public void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Verifica que los campos no esten vacios.
            if (!CamposValidos())
            {
                return;
            }

            // Creamos un objeto Cliente con los datos del formulario
            Cliente nuevoCliente = new Cliente(
                id: 0,  // Este valor lo maneja la base de datos, es autoincremental.
                nombre: txtNombre.Text,
                apellido: txtApellido.Text,
                dni: txtDNI.Text,
                mail: txtEmail.Text,
                telefono: txtTelefono.Text,
                fechaNacimiento: dateFechaNac.Value,
                esSocio: esSocio,
                esApto: esApto
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
                    Limpiar();
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
    }
}

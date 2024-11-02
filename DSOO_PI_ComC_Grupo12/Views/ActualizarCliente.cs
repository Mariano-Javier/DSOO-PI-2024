using DSOO_PI_ComC_Grupo12.Helpers;
using DSOO_PI_ComC_Grupo12.Models;
using DSOO_PI_ComC_Grupo12.Repositories;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSOO_PI_ComC_Grupo12.Views
{
    public partial class ActualizarCliente : Form
    {
        public bool esSocio = true;
        public bool esApto = true;
        public Cliente? ClienteSeleccionado { get; set; }
        public ActualizarCliente()
        {
            InitializeComponent();  
        }
        public void Limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDNI.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            dateFechaNac.Value = DateTime.Now;
            txtClienteIDoDNI.Text = string.Empty;
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
        public bool CamposVacios()
        {
            // Lista de controles a validar
            string[] campos = { txtNombre.Text, txtApellido.Text, txtDNI.Text, txtEmail.Text, txtTelefono.Text };

            // Verifica si algún campo está vacío o con espacios
            return Validaciones.CamposVacios(campos);
        }
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!CamposValidos())
            {
                return;
            }

            if (ClienteSeleccionado == null)
            {
                MessageBox.Show("No hay cliente seleccionado para actualizar.");
                return;
            }

            Cliente clienteActualizado = new Cliente(
                ClienteSeleccionado.Id,
                txtNombre.Text,
                txtApellido.Text,
                txtDNI.Text,
                txtEmail.Text,
                txtTelefono.Text,
                dateFechaNac.Value,
                esSocio,
                esApto
            );

            ClienteRepository clienteRepository = new ClienteRepository();
            bool actualizado = clienteRepository.ActualizarCliente(clienteActualizado);

            if (actualizado)
            {
                MessageBox.Show("Cliente actualizado correctamente.");
                Limpiar();
            }
            else
            {
                MessageBox.Show("Error al actualizar el cliente.");
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ClienteSeleccionado = null;


            string input = txtClienteIDoDNI.Text;
            ClienteRepository clienteRepository = new ClienteRepository();

            if (radioID.Checked)
            {
                if (int.TryParse(input, out int clienteId))
                {
                    Cliente? cliente = clienteRepository.BuscarClientePorId(clienteId);
                    if (cliente != null)
                    {
                        ClienteSeleccionado = cliente;
                        txtNombre.Text = cliente.Nombre;
                        txtApellido.Text = cliente.Apellido;
                        txtDNI.Text = cliente.Dni;
                        txtEmail.Text = cliente.Email;
                        txtTelefono.Text = cliente.Telefono;
                        dateFechaNac.Value = cliente.FechaNacimiento;

                        if (cliente.EsSocio)
                        {
                            radioSocio.Checked = true;
                        }
                        else 
                        {
                            Radio_no_socio.Checked = true;
                        }

                        if (cliente.EsApto)
                        {
                            radioAptoFisicoSi.Checked = true;
                        }
                        else
                        {
                            radioAptoFisicoNo.Checked = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cliente no encontrado.");
                    }
                }
                else
                {
                    MessageBox.Show("ID no válido."); 
                }
            }
            else if (radioDNI.Checked)
            {
                Cliente? cliente = clienteRepository.BuscarClientePorDni(input);
                if (cliente != null)
                {
                    ClienteSeleccionado = cliente;
                    ClienteSeleccionado = cliente;
                    txtNombre.Text = cliente.Nombre;
                    txtApellido.Text = cliente.Apellido;
                    txtDNI.Text = cliente.Dni;
                    txtEmail.Text = cliente.Email;
                    txtTelefono.Text = cliente.Telefono;
                    dateFechaNac.Value = cliente.FechaNacimiento;

                    if (cliente.EsSocio)
                    {
                        radioSocio.Checked = true;
                    }
                    else
                    {
                        Radio_no_socio.Checked = true;
                    }

                    if (cliente.EsApto)
                    {
                        radioAptoFisicoSi.Checked = true;
                    }
                    else
                    {
                        radioAptoFisicoNo.Checked = true;
                    }

                }
                else
                {
                    MessageBox.Show("Cliente no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un tipo de búsqueda.");
            }
        }


    }
}

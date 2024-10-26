using DSOO_PI_ComC_Grupo12.Models;
using DSOO_PI_ComC_Grupo12.Repositories;
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
    public partial class Carnet : Form
    {

        public Carnet()
        {
            InitializeComponent();
            LimpiarCarnet();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LimpiarCarnet() 
        {
            panelCarnet.BackgroundImage = Properties.Resources.blank;
            lblNombreApellidoCarnet.ForeColor = Color.White;
            lblIdCarnet.ForeColor = Color.White;
            lblDniCarnet.ForeColor = Color.White;
            lblTelCarnet.ForeColor = Color.White;
            lblEmailCarnet.ForeColor = Color.White;
        }



        private void radioID_CheckedChanged(object sender, EventArgs e)
        {
            if (radioID.Checked)
            {
                // Limpiar el textbox y el label de resultado
                txtClienteIDoDNI.Clear();
                lblResultadoBusqueda.Text = string.Empty;

                // Habilitar el textbox para la entrada del usuario
                txtClienteIDoDNI.Enabled = true;
            }
        }

        private void radioDNI_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDNI.Checked)
            {
                // Limpiar el textbox y el label de resultado
                txtClienteIDoDNI.Clear();
                lblResultadoBusqueda.Text = string.Empty;

                // Habilitar el textbox para la entrada del usuario
                txtClienteIDoDNI.Enabled = true;
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string input = txtClienteIDoDNI.Text;
            ClienteRepository clienteRepository = new ClienteRepository();

            if (radioID.Checked)
            {
                if (int.TryParse(input, out int clienteId))
                {
                    Cliente? cliente = clienteRepository.BuscarClientePorId(clienteId);
                    if (cliente != null)
                    {
                        lblResultadoBusqueda.Text = "Cliente encontrado: " + cliente.Nombre + " " + cliente.Apellido;
                    }
                    else
                    {
                        lblResultadoBusqueda.Text = "Cliente no encontrado.";
                    }
                }
                else
                {
                    lblResultadoBusqueda.Text = "ID no válido.";
                }
            }
            else if (radioDNI.Checked)
            {
                Cliente? cliente = clienteRepository.BuscarClientePorDni(input);
                if (cliente != null)
                {
                    lblResultadoBusqueda.Text = "Cliente encontrado: " + cliente.Nombre + " " + cliente.Apellido;
                }
                else
                {
                    lblResultadoBusqueda.Text = "Cliente no encontrado.";
                }
            }
            else
            {
                lblResultadoBusqueda.Text = "Seleccione un tipo de búsqueda.";
            }
        }


    }
}

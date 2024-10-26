using DSOO_PI_ComC_Grupo12.Models;
using DSOO_PI_ComC_Grupo12.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSOO_PI_ComC_Grupo12.Views
{
    public partial class Carnet : Form
    {
        public Cliente? ClienteSeleccionado { get; set; }
        public Carnet()
        {
            InitializeComponent();
            LimpiarCarnet();
            btnGenerar.Enabled = false;
            btnImprimir.Enabled = false;

            // Suscribir el evento PrintPage del PrintDocument
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
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
            btnImprimir.Enabled = false;
        }

        private void CarnetSocio()
        {
            panelCarnet.BackgroundImage = Properties.Resources.BCSoc;
            lblNombreApellidoCarnet.ForeColor = Color.NavajoWhite;
            lblIdCarnet.ForeColor = Color.NavajoWhite;
            lblDniCarnet.ForeColor = Color.NavajoWhite;
            lblTelCarnet.ForeColor = Color.NavajoWhite;
            lblEmailCarnet.ForeColor = Color.NavajoWhite;
        }

        private void CarnetComun()
        {
            panelCarnet.BackgroundImage = Properties.Resources.BSNOsocio;
            lblNombreApellidoCarnet.ForeColor = Color.Black;
            lblIdCarnet.ForeColor = Color.Black;
            lblDniCarnet.ForeColor = Color.Black;
            lblTelCarnet.ForeColor = Color.Black;
            lblEmailCarnet.ForeColor = Color.Black;
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
            LimpiarCarnet();
            ClienteSeleccionado = null;
            btnGenerar.Enabled = false;
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
                        btnGenerar.Enabled = true;
                        ClienteSeleccionado = cliente;
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
                    ClienteSeleccionado = cliente;
                    btnGenerar.Enabled = true;
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

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            LimpiarCarnet();

            if (ClienteSeleccionado == null)
            {
                MessageBox.Show("No se ha seleccionado ningún cliente.");
                return;
            }

            PagoRepository pagoRepository = new PagoRepository();
            bool haPagado = pagoRepository.ClienteHaPagado(ClienteSeleccionado.Id);

            if (!haPagado)
            {
                MessageBox.Show("El cliente no registra ningún pago.");
                return;
            }

            if (ClienteSeleccionado.EsSocio)
            {
                // Generar tarjeta gold
                lblNombreApellidoCarnet.Text = ClienteSeleccionado.Nombre + " " + ClienteSeleccionado.Apellido;
                lblIdCarnet.Text = "ID: " + ClienteSeleccionado.Id.ToString();
                lblDniCarnet.Text = "DNI: " + ClienteSeleccionado.Dni;
                lblTelCarnet.Text = "Tel: " + ClienteSeleccionado.Telefono;
                lblEmailCarnet.Text = ClienteSeleccionado.Email;
                CarnetSocio();
                btnImprimir.Enabled = true;
            }
            else
            {
                // Generar tarjeta común
                lblNombreApellidoCarnet.Text = ClienteSeleccionado.Nombre + " " + ClienteSeleccionado.Apellido;
                lblIdCarnet.Text = "ID: " + ClienteSeleccionado.Id.ToString();
                lblDniCarnet.Text = "DNI: " + ClienteSeleccionado.Dni;
                lblTelCarnet.Text = "Tel: " + ClienteSeleccionado.Telefono;
                lblEmailCarnet.Text = ClienteSeleccionado.Email;
                CarnetComun();
                btnImprimir.Enabled = true;
            }
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ClienteSeleccionado = null;
            btnGenerar.Enabled = false;
            LimpiarCarnet();
            txtClienteIDoDNI.Clear();
            lblResultadoBusqueda.Text = string.Empty;
            btnImprimir.Enabled = false;
        }

        //----------------------------------IMPRESION----------------------------------
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(panelCarnet.Width, panelCarnet.Height);
            panelCarnet.DrawToBitmap(bitmap, new Rectangle(0, 0, panelCarnet.Width, panelCarnet.Height));
            e.Graphics.DrawImage(bitmap, 0, 0);
        }


        //------------------------------FIN-IMPRESION----------------------------------
    }
}

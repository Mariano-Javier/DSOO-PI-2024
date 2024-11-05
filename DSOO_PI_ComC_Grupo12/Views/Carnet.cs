using DSOO_PI_ComC_Grupo12.Controllers;
using DSOO_PI_ComC_Grupo12.Models;
using System;
using System.Windows.Forms;

namespace DSOO_PI_ComC_Grupo12.Views
{
    public partial class Carnet : Form
    {
        public Cliente? ClienteSeleccionado { get; set; }
        private DateTime? FechaHoy;
        private readonly CarnetController _carnetController;

        public Carnet()
        {
            InitializeComponent();
            _carnetController = new CarnetController();
            _carnetController.LimpiarCarnet(panelCarnet, lblNombreApellidoCarnet, lblIdCarnet, lblDniCarnet, lblTelCarnet, lblEmailCarnet, lblVencimiento, lblEsApto, btnImprimir, lblEstadoCarnet);
            btnGenerar.Enabled = false;
            btnImprimir.Enabled = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
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
            _carnetController.LimpiarCarnet(panelCarnet, lblNombreApellidoCarnet, lblIdCarnet, lblDniCarnet, lblTelCarnet, lblEmailCarnet, lblVencimiento, lblEsApto, btnImprimir, lblEstadoCarnet);
            ClienteSeleccionado = null;
            btnGenerar.Enabled = false;
            string input = txtClienteIDoDNI.Text;

            Cliente? cliente = _carnetController.BuscarCliente(input, radioID.Checked);
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

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            _carnetController.LimpiarCarnet(panelCarnet, lblNombreApellidoCarnet, lblIdCarnet, lblDniCarnet, lblTelCarnet, lblEmailCarnet, lblVencimiento, lblEsApto, btnImprimir, lblEstadoCarnet);
            FechaHoy = DateTime.Now;

            if (ClienteSeleccionado == null)
            {
                MessageBox.Show("No se ha seleccionado ningún cliente.");
                return;
            }

            bool haPagado = _carnetController.ClienteHaPagado(ClienteSeleccionado.Id);

            if (!haPagado)
            {
                MessageBox.Show("El cliente no registra ningún pago.");
                return;
            }

            _carnetController.GenerarCarnet(ClienteSeleccionado, FechaHoy.Value, panelCarnet, lblNombreApellidoCarnet, lblIdCarnet, lblDniCarnet, lblTelCarnet, lblEmailCarnet, lblVencimiento, lblEsApto, btnImprimir, lblEstadoCarnet);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ClienteSeleccionado = null;
            btnGenerar.Enabled = false;
            _carnetController.LimpiarCarnet(panelCarnet, lblNombreApellidoCarnet, lblIdCarnet, lblDniCarnet, lblTelCarnet, lblEmailCarnet, lblVencimiento, lblEsApto, btnImprimir, lblEstadoCarnet);
            txtClienteIDoDNI.Clear();
            lblResultadoBusqueda.Text = string.Empty;
            btnImprimir.Enabled = false;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            // muestra el  setup dialog 
            pageSetupDialog.Document = _carnetController.GetPrintDocument();
            if (pageSetupDialog.ShowDialog() == DialogResult.OK)
            {
                // muestra el print dialog para seleccionar las opciones de impresion
                printDialog.Document = _carnetController.GetPrintDocument();
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    // si se confirman las opciones pasa a imprimir
                    _carnetController.ImprimirCarnet(panelCarnet);
                }
            }
        }
    }
}

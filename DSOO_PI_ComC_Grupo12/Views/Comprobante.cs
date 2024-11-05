using DSOO_PI_ComC_Grupo12.Controllers;
using DSOO_PI_ComC_Grupo12.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DSOO_PI_ComC_Grupo12.Views
{
    public partial class Comprobante : Form
    {
        private Cliente? Cliente { get; set; }
        private DateTime FechaPago { get; set; }
        private DateTime FechaInicio { get; set; }
        private DateTime FechaFin { get; set; }
        private readonly ComprobanteController _comprobanteController;

        public Comprobante(Cliente cliente, DateTime fechaPago, String FormaPago, Decimal TotalPagar, List<Actividad> actividades, DateTime fechaInicio)
        {
            InitializeComponent();
            _comprobanteController = new ComprobanteController();
            Cliente = cliente;
            FechaPago = fechaPago;
            FechaInicio = fechaInicio;

            lblNombreApellido.Text = $"{cliente.Nombre} {cliente.Apellido}";
            lblDNI.Text = cliente.Dni;
            lblFechaPago.Text = fechaPago.ToString("dd/MM/yyyy");
            lblFormaPago.Text = FormaPago;
            lblTotal.Text = TotalPagar.ToString() + " $";

            dataGridResumen.DefaultCellStyle.SelectionBackColor = Color.White;
            dataGridResumen.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridFechas.DefaultCellStyle.SelectionBackColor = Color.White;
            dataGridFechas.DefaultCellStyle.SelectionForeColor = Color.Black;

            _comprobanteController.CargarDataGridViewNS(actividades, dataGridResumen, dataGridFechas, fechaInicio);
        }

        public Comprobante(Cliente cliente, DateTime fechaPago, String FormaPago, Decimal TotalPagar, List<Actividad> actividades, DateTime fechaInicio, DateTime fechaFin)
        {
            InitializeComponent();
            _comprobanteController = new ComprobanteController();
            Cliente = cliente;
            FechaPago = fechaPago;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;

            lblNombreApellido.Text = $"{cliente.Nombre} {cliente.Apellido}";
            lblDNI.Text = cliente.Dni;
            lblFechaPago.Text = fechaPago.ToString("dd/MM/yyyy");
            lblFormaPago.Text = FormaPago;
            lblTotal.Text = TotalPagar.ToString() + " $";

            dataGridResumen.DefaultCellStyle.SelectionBackColor = Color.White;
            dataGridResumen.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridFechas.DefaultCellStyle.SelectionBackColor = Color.White;
            dataGridFechas.DefaultCellStyle.SelectionForeColor = Color.Black;

            _comprobanteController.CargarDataGridViewS(actividades, dataGridResumen, dataGridFechas, fechaInicio, fechaFin);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            // muestra el  setup dialog 
            pageSetupDialog.Document = _comprobanteController.GetPrintDocument();
            if (pageSetupDialog.ShowDialog() == DialogResult.OK)
            {
                // muestra el print dialog para seleccionar las opciones de impresion
                printDialog.Document = _comprobanteController.GetPrintDocument();
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    // si se confirman las opciones pasa a imprimir
                    _comprobanteController.ImprimirComprobante(panelComprobante);
                }
            }
        }
    }
}

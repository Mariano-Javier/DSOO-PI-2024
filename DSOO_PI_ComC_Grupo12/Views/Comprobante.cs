using DSOO_PI_ComC_Grupo12.Models;
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
    public partial class Comprobante : Form
    {
        private Cliente? Cliente { get; set; }
        private DateTime FechaPago { get; set; }
        public Comprobante(Cliente cliente, DateTime fechaPago,String FormaPago, Decimal TotalPagar, Dictionary<String,decimal> preciosActividades)
        {
            InitializeComponent();
            Cliente = cliente;
            FechaPago = fechaPago;
            lblNombreApellido.Text = $"{cliente.Nombre} {cliente.Apellido}";
            lblDNI.Text = cliente.Dni;
            lblFechaPago.Text = fechaPago.ToString("dd/MM/yyyy");
            lblFormaPago.Text = FormaPago;
            lblTotal.Text = TotalPagar.ToString()+" $";
            dataGridResumen.DefaultCellStyle.SelectionBackColor = Color.White;
            dataGridResumen.DefaultCellStyle.SelectionForeColor = Color.Black;
            CargarDataGridView(preciosActividades);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //modificar: poner en una clase estatica:-> RegistrarPago y Comprobante
        private void CargarDataGridView(Dictionary<string, decimal> preciosActividades)
        {
            // Limpiar el DataGridView antes de cargar nuevos datos
            dataGridResumen.Rows.Clear();

            // Iterar a través del diccionario y agregar filas al DataGridView
            foreach (var actividad in preciosActividades)
            {
                dataGridResumen.Rows.Add(actividad.Key, actividad.Value);
            }
        }
    }
}

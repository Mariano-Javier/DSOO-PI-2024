using System;
using System.Windows.Forms;
using DSOO_PI_ComC_Grupo12.Controllers;

namespace DSOO_PI_ComC_Grupo12.Views
{
    public partial class EditarDescuentoForm : Form
    {
        public int Id { get; private set; }
        public string Tipo { get; private set; }
        public decimal Descuento { get; private set; }

        private EditarDescuentoController controller;

        public EditarDescuentoForm(int id, string tipo, decimal descuento)
        {
            InitializeComponent();
            Id = id;
            Tipo = tipo;
            Descuento = descuento;
            txtId.Text = id.ToString();
            txtTipo.Text = tipo;
            // Convertir el valor de descuento a porcentaje
            txtDescuento.Text = (descuento * 100).ToString("0.##");
            controller = new EditarDescuentoController(txtTipo, txtDescuento);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var datos = controller.ObtenerDatos();
            Tipo = datos.Tipo;
            Descuento = datos.Descuento;
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}

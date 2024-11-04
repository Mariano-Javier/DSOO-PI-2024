using System;
using System.Windows.Forms;
using DSOO_PI_ComC_Grupo12.Controllers;

namespace DSOO_PI_ComC_Grupo12.Views
{
    public partial class EditarCuotaForm : Form
    {
        public string Descripcion { get; private set; }
        public decimal Monto { get; private set; }

        private EditarCuotaController controller;

        public EditarCuotaForm(int id, string descripcion, decimal monto)
        {
            InitializeComponent();
            txtId.Text = id.ToString();
            txtDescripcion.Text = descripcion;
            txtMonto.Text = monto.ToString();
            controller = new EditarCuotaController(txtDescripcion, txtMonto);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (controller.ValidarCampos())
            {
                var datos = controller.ObtenerDatos();
                Descripcion = datos.Descripcion;
                Monto = datos.Monto;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

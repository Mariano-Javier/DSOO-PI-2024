using System;
using System.Windows.Forms;
using DSOO_PI_ComC_Grupo12.Controllers;

namespace DSOO_PI_ComC_Grupo12.Views
{
    public partial class EditarActividadForm : Form
    {
        public string Nombre { get; private set; }
        public decimal Precio { get; private set; }

        private EditarActividadController controller;

        public EditarActividadForm(int id, string nombre, decimal precio)
        {
            InitializeComponent();
            txtId.Text = id.ToString();
            txtNombre.Text = nombre;
            txtPrecio.Text = precio.ToString();
            controller = new EditarActividadController(txtNombre, txtPrecio);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (controller.ValidarCampos())
            {
                var datos = controller.ObtenerDatos();
                Nombre = datos.Nombre;
                Precio = datos.Precio;
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

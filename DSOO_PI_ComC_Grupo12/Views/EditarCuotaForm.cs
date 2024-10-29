using System;
using System.Windows.Forms;

namespace DSOO_PI_ComC_Grupo12.Views
{
    public partial class EditarCuotaForm : Form
    {
        public string Descripcion { get; private set; }
        public decimal Monto { get; private set; }

        public EditarCuotaForm(int id, string descripcion, decimal monto)
        {
            InitializeComponent();
            txtId.Text = id.ToString();
            txtDescripcion.Text = descripcion;
            txtMonto.Text = monto.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Descripcion = txtDescripcion.Text;
                Monto = decimal.Parse(txtMonto.Text);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("El campo Descripción no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMonto.Text))
            {
                MessageBox.Show("El campo Monto no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!decimal.TryParse(txtMonto.Text, out _))
            {
                MessageBox.Show("El campo Monto debe ser un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}

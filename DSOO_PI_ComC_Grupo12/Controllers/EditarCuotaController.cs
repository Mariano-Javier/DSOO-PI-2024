using System;
using System.Windows.Forms;

namespace DSOO_PI_ComC_Grupo12.Controllers
{
    public class EditarCuotaController
    {
        private TextBox txtDescripcion;
        private TextBox txtMonto;

        public EditarCuotaController(TextBox txtDescripcion, TextBox txtMonto)
        {
            this.txtDescripcion = txtDescripcion;
            this.txtMonto = txtMonto;
        }

        public bool ValidarCampos()
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

        public (string Descripcion, decimal Monto) ObtenerDatos()
        {
            return (txtDescripcion.Text, decimal.Parse(txtMonto.Text));
        }
    }
}

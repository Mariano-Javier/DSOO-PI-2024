using System;
using System.Windows.Forms;

namespace DSOO_PI_ComC_Grupo12.Controllers
{
    public class EditarActividadController
    {
        private TextBox txtNombre;
        private TextBox txtPrecio;

        public EditarActividadController(TextBox txtNombre, TextBox txtPrecio)
        {
            this.txtNombre = txtNombre;
            this.txtPrecio = txtPrecio;
        }

        public bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El campo Nombre no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("El campo Precio no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!decimal.TryParse(txtPrecio.Text, out _))
            {
                MessageBox.Show("El campo Precio debe ser un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public (string Nombre, decimal Precio) ObtenerDatos()
        {
            return (txtNombre.Text, decimal.Parse(txtPrecio.Text));
        }
    }
}

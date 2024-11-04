using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DSOO_PI_ComC_Grupo12.Controllers
{
    public class EditarDescuentoController
    {
        private TextBox txtTipo;
        private TextBox txtDescuento;

        public EditarDescuentoController(TextBox txtTipo, TextBox txtDescuento)
        {
            this.txtTipo = txtTipo;
            this.txtDescuento = txtDescuento;
            txtDescuento.Validating += txtDescuento_Validating;
        }

        public (string Tipo, decimal Descuento) ObtenerDatos()
        {
            return (txtTipo.Text, decimal.Parse(txtDescuento.Text) / 100);
        }

        private void txtDescuento_Validating(object sender, CancelEventArgs e)
        {
            if (decimal.TryParse(txtDescuento.Text, out decimal descuento))
            {
                if (descuento < 0 || descuento > 100)
                {
                    MessageBox.Show("El valor de descuento debe estar entre 0 y 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
            else
            {
                MessageBox.Show("El valor de descuento debe ser un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }
    }
}

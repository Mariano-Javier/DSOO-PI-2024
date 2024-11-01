using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DSOO_PI_ComC_Grupo12.Views
{
    public partial class EditarDescuentoForm : Form
    {
        public int Id { get; private set; }
        public string Tipo { get; private set; }
        public decimal Descuento { get; private set; }

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

            // Suscribir el evento Validating
            txtDescuento.Validating += txtDescuento_Validating;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Tipo = txtTipo.Text;
            // Convertir el valor de porcentaje a su valor decimal correspondiente
            Descuento = decimal.Parse(txtDescuento.Text) / 100;
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
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

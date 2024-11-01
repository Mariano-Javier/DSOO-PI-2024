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
            txtDescuento.Text = descuento.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Tipo = txtTipo.Text;
            Descuento = decimal.Parse(txtDescuento.Text);
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}

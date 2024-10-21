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
    public partial class RegistrarPago : Form
    {
        public RegistrarPago()
        {
            InitializeComponent();
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            // Ocultar todas las ventanas abiertas menos la ventana emergente
            foreach (Form form in Application.OpenForms)
            {
                if (form != this) // Omitimos la ventana actual, se oculta al final
                {
                    form.Hide();
                }
            }

            // Oculta la ventana actual (si es necesario)
            this.Hide();

            // Crea y muestra la ventana emergente
            Comprobante comprobante = new Comprobante();
            comprobante.ShowDialog(); // Mostrar como ventana modal

            // Cuando la ventana emergente se cierra, volvemos a mostrar todas las ventanas ocultas
            foreach (Form form in Application.OpenForms)
            {
                form.Show();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

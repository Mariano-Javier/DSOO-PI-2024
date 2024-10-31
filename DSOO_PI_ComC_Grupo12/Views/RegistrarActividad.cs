using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DSOO_PI_ComC_Grupo12.Repositories;

namespace DSOO_PI_ComC_Grupo12.Views
{
    public partial class RegistrarActividad : Form
    {
        private ActividadRepository actividadRepository;

        public RegistrarActividad()
        {
            InitializeComponent();
            actividadRepository = new ActividadRepository();
            CargarActividadesEnDataGrid();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {
                    string nombre = txtNombre.Text;
                    decimal precio = decimal.Parse(txtPrecio.Text);

                    actividadRepository.RegistrarActividad(nombre, precio);

                    MessageBox.Show("Actividad registrada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarActividadesEnDataGrid();
                    txtNombre.Text = string.Empty;
                    txtPrecio.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar la actividad: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidarCampos()
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = string.Empty;
            txtPrecio.Text = string.Empty; 

        }
        private void CargarActividadesEnDataGrid()
        {
            try
            {
                var actividades = actividadRepository.ObtenerPreciosActividades();
                dataGridActividades.Rows.Clear(); // Limpiar las filas existentes

                foreach (var actividad in actividades)
                {
                    dataGridActividades.Rows.Add(actividad.Id, actividad.Nombre, actividad.Precio);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las actividades: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

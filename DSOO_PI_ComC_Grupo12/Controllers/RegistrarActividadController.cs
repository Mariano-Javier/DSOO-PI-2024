using DSOO_PI_ComC_Grupo12.Models;
using DSOO_PI_ComC_Grupo12.Repositories;
using System;
using System.Windows.Forms;

namespace DSOO_PI_ComC_Grupo12.Controllers
{
    public class RegistrarActividadController
    {
        private readonly ActividadRepository _actividadRepository;

        public RegistrarActividadController()
        {
            _actividadRepository = new ActividadRepository();
        }

        public void Limpiar(TextBox txtNombre, TextBox txtPrecio)
        {
            txtNombre.Text = string.Empty;
            txtPrecio.Text = string.Empty;
        }

        public bool ValidarCampos(TextBox txtNombre, TextBox txtPrecio)
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

        public void RegistrarActividad(TextBox txtNombre, TextBox txtPrecio, DataGridView dataGridActividades)
        {
            if (ValidarCampos(txtNombre, txtPrecio))
            {
                try
                {
                    string nombre = txtNombre.Text;
                    decimal precio = decimal.Parse(txtPrecio.Text);

                    var actividad = new Actividad
                    {
                        Nombre = nombre,
                        Precio = precio
                    };

                    _actividadRepository.RegistrarActividad(actividad);

                    MessageBox.Show("Actividad registrada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarActividadesEnDataGrid(dataGridActividades);
                    Limpiar(txtNombre, txtPrecio);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar la actividad: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void CargarActividadesEnDataGrid(DataGridView dataGridActividades)
        {
            try
            {
                var actividades = _actividadRepository.ObtenerActividades();
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

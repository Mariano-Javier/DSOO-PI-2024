using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DSOO_PI_ComC_Grupo12.Repositories;

namespace DSOO_PI_ComC_Grupo12.Views
{
    public partial class ActualizarActividades : Form
    {
        private ActividadRepository actividadRepository;

        public ActualizarActividades()
        {
            InitializeComponent();
            actividadRepository = new ActividadRepository();
            ConfigurarDataGridView();
            CargarActividadesEnDataGrid();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ConfigurarDataGridView()
        {
            // Configurar las columnas del DataGridView
            dataGridActividades.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ID",
                HeaderText = "ID",
                DataPropertyName = "ID",
                Width = 30

            });
            dataGridActividades.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Nombre",
                HeaderText = "Nombre",
                DataPropertyName = "Nombre",
                Width = 350
            });
            dataGridActividades.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Precio",
                HeaderText = "Precio",
                DataPropertyName = "Precio"
            });

            // Agregar columnas de botones
            DataGridViewButtonColumn btnActualizar = new DataGridViewButtonColumn
            {
                Name = "Actualizar",
                HeaderText = "Actualizar",
                Text = "Actualizar",
                UseColumnTextForButtonValue = true
            };
            dataGridActividades.Columns.Add(btnActualizar);

            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn
            {
                Name = "Eliminar",
                HeaderText = "Eliminar",
                Text = "Eliminar",
                UseColumnTextForButtonValue = true
            };
            dataGridActividades.Columns.Add(btnEliminar);

            // Manejar el evento de clic de las celdas
            dataGridActividades.CellClick += DataGridActividades_CellClick;
        }

        private void DataGridActividades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridActividades.Columns[e.ColumnIndex].Name == "Actualizar")
                {
                    // Lógica para actualizar la fila
                    int id = (int)dataGridActividades.Rows[e.RowIndex].Cells["ID"].Value;
                    string nombre = dataGridActividades.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                    decimal precio = decimal.Parse(dataGridActividades.Rows[e.RowIndex].Cells["Precio"].Value.ToString());

                    // Aquí puedes abrir un formulario de edición o actualizar directamente
                    // Por ejemplo, abrir un formulario de edición
                    EditarActividadForm editarForm = new EditarActividadForm(id, nombre, precio);
                    if (editarForm.ShowDialog() == DialogResult.OK)
                    {
                        // Actualizar la actividad en la base de datos
                        actividadRepository.ActualizarActividad(id, editarForm.Nombre, editarForm.Precio);
                        CargarActividadesEnDataGrid();
                    }
                }
                else if (dataGridActividades.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    // Lógica para eliminar la fila
                    int id = (int)dataGridActividades.Rows[e.RowIndex].Cells["ID"].Value;
                    string nombre = dataGridActividades.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();

                    DialogResult result = MessageBox.Show($"¿Estás seguro de que deseas eliminar la actividad: ID={id}, Nombre={nombre}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            actividadRepository.EliminarActividad(id);
                            MessageBox.Show("Actividad eliminada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarActividadesEnDataGrid();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al eliminar la actividad: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
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

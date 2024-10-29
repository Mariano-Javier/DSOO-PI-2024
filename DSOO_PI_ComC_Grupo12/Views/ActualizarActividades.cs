using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DSOO_PI_ComC_Grupo12.Repositories;

namespace DSOO_PI_ComC_Grupo12.Views
{
    public partial class ActualizarActividades : Form
    {
        private ActividadRepository actividadRepository;
        private CuotaSocioRepository cuotaSocioRepository;

        public ActualizarActividades()
        {
            InitializeComponent();
            actividadRepository = new ActividadRepository();
            cuotaSocioRepository = new CuotaSocioRepository();
            ConfigurarDataGridView();
            CargarActividadesEnDataGrid();
            CargarCuotasEnDataGrid();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ConfigurarDataGridView()
        {
            // Configurar las columnas del DataGridView para actividades
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

            // Agregar columnas de botones para actividades
            DataGridViewButtonColumn btnActualizarActividad = new DataGridViewButtonColumn
            {
                Name = "ActualizarActividad",
                HeaderText = "Actualizar",
                Text = "Actualizar",
                UseColumnTextForButtonValue = true
            };
            dataGridActividades.Columns.Add(btnActualizarActividad);

            DataGridViewButtonColumn btnEliminarActividad = new DataGridViewButtonColumn
            {
                Name = "EliminarActividad",
                HeaderText = "Eliminar",
                Text = "Eliminar",
                UseColumnTextForButtonValue = true
            };
            dataGridActividades.Columns.Add(btnEliminarActividad);

            // Manejar el evento de clic de las celdas para actividades
            dataGridActividades.CellClick += DataGridActividades_CellClick;

            // Configurar las columnas del DataGridView para cuotas
            dataGridCuota.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IDCuota",
                HeaderText = "ID",
                DataPropertyName = "IDCuota",
                Width = 30
            });
            dataGridCuota.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Descripcion",
                HeaderText = "Descripción",
                DataPropertyName = "Descripcion",
                Width = 450
            });
            dataGridCuota.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Monto",
                HeaderText = "Monto",
                DataPropertyName = "Monto"
            });

            // Agregar solo la columna de botones "Actualizar" para cuotas
            DataGridViewButtonColumn btnActualizarCuota = new DataGridViewButtonColumn
            {
                Name = "ActualizarCuota",
                HeaderText = "Actualizar",
                Text = "Actualizar",
                UseColumnTextForButtonValue = true
            };
            dataGridCuota.Columns.Add(btnActualizarCuota);

            // Manejar el evento de clic de las celdas para cuotas
            dataGridCuota.CellClick += DataGridCuota_CellClick;
        }

        private void DataGridActividades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridActividades.Columns[e.ColumnIndex].Name == "ActualizarActividad")
                {
                    // Lógica para actualizar la fila de actividades
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
                else if (dataGridActividades.Columns[e.ColumnIndex].Name == "EliminarActividad")
                {
                    // Lógica para eliminar la fila de actividades
                    int id = (int)dataGridActividades.Rows[e.RowIndex].Cells["ID"].Value;
                    string nombre = dataGridActividades.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();

                    // Verificar si hay al menos una actividad en el DataGridView
                    if (dataGridActividades.Rows.Count > 1)
                    {
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
                    else
                    {
                        MessageBox.Show("No se puede eliminar la última actividad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void DataGridCuota_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridCuota.Columns[e.ColumnIndex].Name == "ActualizarCuota")
                {
                    // Lógica para actualizar la fila de cuotas
                    int id = (int)dataGridCuota.Rows[e.RowIndex].Cells["IDCuota"].Value;
                    string descripcion = dataGridCuota.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
                    decimal monto = decimal.Parse(dataGridCuota.Rows[e.RowIndex].Cells["Monto"].Value.ToString());

                    // Aquí puedes abrir un formulario de edición o actualizar directamente
                    // Por ejemplo, abrir un formulario de edición
                    EditarCuotaForm editarForm = new EditarCuotaForm(id, descripcion, monto);
                    if (editarForm.ShowDialog() == DialogResult.OK)
                    {
                        // Actualizar la cuota en la base de datos
                        cuotaSocioRepository.ActualizarCuota(id, editarForm.Descripcion, editarForm.Monto);
                        CargarCuotasEnDataGrid();
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

        private void CargarCuotasEnDataGrid()
        {
            try
            {
                var cuotas = cuotaSocioRepository.ObtenerPreciosCuotas();
                dataGridCuota.Rows.Clear(); // Limpiar las filas existentes

                foreach (var cuota in cuotas)
                {
                    dataGridCuota.Rows.Add(cuota.Id, cuota.Descripcion, cuota.Monto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las cuotas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

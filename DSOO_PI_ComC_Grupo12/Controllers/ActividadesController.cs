using System;
using System.Windows.Forms;
using DSOO_PI_ComC_Grupo12.Models;
using DSOO_PI_ComC_Grupo12.Repositories;
using DSOO_PI_ComC_Grupo12.Views;

namespace DSOO_PI_ComC_Grupo12.Controllers
{
    public class ActividadesController
    {
        private ActividadRepository actividadRepository;
        private CuotaSocioRepository cuotaSocioRepository;
        private DescuentosRepository descuentosRepository;

        public ActividadesController()
        {
            actividadRepository = new ActividadRepository();
            cuotaSocioRepository = new CuotaSocioRepository();
            descuentosRepository = new DescuentosRepository();
        }

        public void ConfigurarDataGridView(DataGridView dataGridActividades, DataGridView dataGridCuota, DataGridView dataGridDescuentos)
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
                Width = 420
            });
            dataGridCuota.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Monto",
                HeaderText = "Monto",
                DataPropertyName = "Monto",
                Width = 130
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

            // Configurar las columnas del DataGridView para descuentos
            dataGridDescuentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IDDescuento",
                HeaderText = "ID",
                DataPropertyName = "IDDescuento",
                Width = 30
            });
            dataGridDescuentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Tipo",
                HeaderText = "Tipo",
                DataPropertyName = "Tipo",
                Width = 420
            });
            dataGridDescuentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Descuento",
                HeaderText = "Descuento %",
                DataPropertyName = "Descuento",
                Width = 130
            });

            // Agregar columna de botones para actualizar descuentos
            DataGridViewButtonColumn btnActualizarDescuento = new DataGridViewButtonColumn
            {
                Name = "ActualizarDescuento",
                HeaderText = "Actualizar",
                Text = "Actualizar",
                UseColumnTextForButtonValue = true
            };
            dataGridDescuentos.Columns.Add(btnActualizarDescuento);

            // Manejar el evento de clic de las celdas para descuentos
            dataGridDescuentos.CellClick += DataGridDescuentos_CellClick;
        }

        private void DataGridActividades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridView dataGridActividades = (DataGridView)sender;
                if (dataGridActividades.Columns[e.ColumnIndex].Name == "ActualizarActividad")
                {
                    // Obtengo los valores de las celdas
                    int id = (int)dataGridActividades.Rows[e.RowIndex].Cells["ID"].Value;
                    string nombre = dataGridActividades.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                    decimal precio = decimal.Parse(dataGridActividades.Rows[e.RowIndex].Cells["Precio"].Value.ToString());

                    // Abro un formulario para editar
                    EditarActividadForm editarForm = new EditarActividadForm(id, nombre, precio);
                    if (editarForm.ShowDialog() == DialogResult.OK)
                    {
                        // Actualizar la actividad en la base de datos
                        var actividad = new Actividad
                        {
                            Id = id,
                            Nombre = editarForm.Nombre,
                            Precio = editarForm.Precio
                        };
                        actividadRepository.ActualizarActividad(actividad);
                        CargarActividadesEnDataGrid(dataGridActividades);
                    }
                }
                else if (dataGridActividades.Columns[e.ColumnIndex].Name == "EliminarActividad")
                {
                    // Obtengo los valores de la celda
                    int id = (int)dataGridActividades.Rows[e.RowIndex].Cells["ID"].Value;
                    string nombre = dataGridActividades.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();

                    // Verifico si hay al menos una actividad en el DataGridView para evitar tener problemas a la hora de facturar.
                    if (dataGridActividades.Rows.Count > 1)
                    {
                        DialogResult result = MessageBox.Show($"¿Estás seguro de que deseas eliminar la actividad: ID={id}, Nombre={nombre}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            try
                            {
                                actividadRepository.EliminarActividad(id);
                                MessageBox.Show("Actividad eliminada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CargarActividadesEnDataGrid(dataGridActividades);
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
                DataGridView dataGridCuota = (DataGridView)sender;
                if (dataGridCuota.Columns[e.ColumnIndex].Name == "ActualizarCuota")
                {
                    // Obtengo valores de las variables de la celda
                    int id = (int)dataGridCuota.Rows[e.RowIndex].Cells["IDCuota"].Value;
                    string descripcion = dataGridCuota.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
                    decimal monto = decimal.Parse(dataGridCuota.Rows[e.RowIndex].Cells["Monto"].Value.ToString());

                    // Abro un formulario para editar
                    EditarCuotaForm editarForm = new EditarCuotaForm(id, descripcion, monto);
                    if (editarForm.ShowDialog() == DialogResult.OK)
                    {
                        // Actualizar la cuota en la base de datos
                        Cuota cuota = new Cuota
                        {
                            Id = id,
                            Descripcion = editarForm.Descripcion,
                            Monto = editarForm.Monto
                        };
                        cuotaSocioRepository.ActualizarCuota(cuota);
                        CargarCuotasEnDataGrid(dataGridCuota);
                    }
                }
            }
        }

        private void DataGridDescuentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridView dataGridDescuentos = (DataGridView)sender;
                if (dataGridDescuentos.Columns[e.ColumnIndex].Name == "ActualizarDescuento")
                {
                    // Obtengo los valores de las celdas
                    int id = (int)dataGridDescuentos.Rows[e.RowIndex].Cells["IDDescuento"].Value;
                    string tipo = dataGridDescuentos.Rows[e.RowIndex].Cells["Tipo"].Value.ToString();
                    decimal descuento = decimal.Parse(dataGridDescuentos.Rows[e.RowIndex].Cells["Descuento"].Value.ToString());

                    // Convertir el valor de descuento a porcentaje
                    descuento = descuento / 100;

                    // Abro un formulario para editar
                    EditarDescuentoForm editarForm = new EditarDescuentoForm(id, tipo, descuento);
                    if (editarForm.ShowDialog() == DialogResult.OK)
                    {
                        // Actualizar el descuento en la base de datos
                        var descuentoActualizado = new Descuento
                        {
                            Id = id,
                            TipoPago = editarForm.Tipo,
                            ValorDescuento = editarForm.Descuento
                        };
                        descuentosRepository.ActualizarDescuento(descuentoActualizado);
                        CargarDescuentosEnDataGrid(dataGridDescuentos);
                    }
                }
            }
        }

        public void CargarActividadesEnDataGrid(DataGridView dataGridActividades)
        {
            try
            {
                var actividades = actividadRepository.ObtenerActividades();
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

        public void CargarCuotasEnDataGrid(DataGridView dataGridCuota)
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

        public void CargarDescuentosEnDataGrid(DataGridView dataGridDescuentos)
        {
            try
            {
                var descuentos = descuentosRepository.ObtenerDescuentos();
                dataGridDescuentos.Rows.Clear(); // Limpiar las filas existentes

                foreach (var descuento in descuentos)
                {
                    // Convertir el valor de descuento a porcentaje
                    decimal porcentajeDescuento = descuento.ValorDescuento * 100;

                    // Agregar los datos al DataGridView con el porcentaje formateado
                    dataGridDescuentos.Rows.Add(descuento.Id, descuento.TipoPago, porcentajeDescuento.ToString("0.##"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los descuentos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

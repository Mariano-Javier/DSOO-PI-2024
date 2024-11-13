using DSOO_PI_ComC_Grupo12.Interfaces;
using DSOO_PI_ComC_Grupo12.Models;
using DSOO_PI_ComC_Grupo12.Repositories;
using DSOO_PI_ComC_Grupo12.Utils;
using DSOO_PI_ComC_Grupo12.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DSOO_PI_ComC_Grupo12.Controllers
{
    public class RegistrarPagoController
    {   // La palabra clave readonly asegura que estas dependencias no puedan ser reasignadas, mejorando así la integridad del estado del controlador y simplificando el flujo de datos dentro de la aplicación.
        private readonly RegistrarPago _view;// me da acceso  a  a los elementos de la vista RegistrarPago, lo que permite al controlador interactuar con la interfaz de usuario, como actualizar controles, leer entradas de usuario, y controlar eventos. 
        private readonly ActividadRepository _actividadRepository;//permite que el RegistrarPagoController tenga acceso centralizado a la lógica de obtención de datos de actividades, desacoplando la lógica de acceso a datos de la lógica de presentación.
        private List<Actividad> _actividades;

        public RegistrarPagoController(RegistrarPago view)
        {
            _view = view;
            _actividadRepository = new ActividadRepository();
            _actividades = new List<Actividad>();
        }

        public void Initialize()
        {
            _view.ventanasAbiertas = new List<Form>();
            _view.actividadesSeleccionadas = new List<string>();
            _view.TotalPagar = 0;
            _view.EstadoPagado = false;
            _view.dateFechaPago.Value = DateTime.Now;
            _view.dateDiaSeleccionado.Value = DateTime.Now;
            _view.btnPagar.Enabled = false;
            _view.btnComprobante.Enabled = false;
            _view.btnCalcular.Enabled = false;

            // Cargar las actividades en el DataGridView
            CargarActividadesEnDataGrid();
        }

        public void ResetearRadioButtons()
        {
            _view.radioEfectivo.Checked = true;
            // Restablecer el valor de la variable a su valor original
            _view.FormaPago = "Efectivo";
        }

        public void ResetearCheckBoxes()
        {
            foreach (DataGridViewRow row in _view.dataGridSelecActi.Rows)
            {
                // Establecer el valor de la columna "Seleccion" a false
                row.Cells["Seleccion"].Value = false;
            }
        }

        public void CargarDataGridView(List<Actividad> actividades)
        {
            // Limpiar el DataGridView antes de cargar nuevos datos
            _view.dataGridResumen.Rows.Clear();

            // Iterar a través de la lista de actividades y agregar filas al DataGridView
            foreach (var actividad in actividades)
            {
                _view.dataGridResumen.Rows.Add(actividad.Nombre, actividad.Precio);
            }
        }

        public void btnComprobante_Click(object sender, EventArgs e)
        {
            if (_view.EstadoPagado == false)
            {
                MessageBox.Show("Debe realizar el pago antes de poder emitir el comprobante.");
                return;
            }
            // Verificar si se ha seleccionado un cliente
            if (_view.ClienteSeleccionado != null)
            {
                // Guardar las ventanas abiertas en la lista, excluyendo la ventana de Login
                _view.ventanasAbiertas.Clear();
                foreach (Form form in Application.OpenForms)
                {
                    if (form != _view && !(form is Login)) // Se omite la ventana actual y la ventana de Login
                    {
                        _view.ventanasAbiertas.Add(form);
                        form.Hide();
                    }
                }

                // Oculta la ventana actual (si es necesario)
                _view.Hide();

                // Obtener la fecha seleccionada en el DateTimePicker
                DateTime fechaPago = _view.dateFechaPago.Value;

                DateTime fechaSeleccionada = _view.dateDiaSeleccionado.Value;

                // Crea y muestra la ventana emergente
                Comprobante comprobante = new Comprobante(_view.ClienteSeleccionado, fechaPago, _view.FormaPago, _view.TotalPagar, _actividades, fechaSeleccionada);
                comprobante.ShowDialog(); // Mostrar como ventana modal

                // Cuando la ventana emergente se cierra, volvemos a mostrar todas las ventanas ocultas
                _view.Show();
                foreach (Form form in _view.ventanasAbiertas)
                {
                    form.Show();
                }
            }
            else
            {
                // Mostrar un mensaje de error si no se ha seleccionado un cliente
                MessageBox.Show("Por favor, busque y seleccione un cliente antes de generar el comprobante.");
            }
        }

        public void btnCerrar_Click(object sender, EventArgs e)
        {
            _view.Close();
        }

        public void btnLimpiar_Click(object sender, EventArgs e)
        {
            _view.txtClienteID.Text = string.Empty;
            Limpiar();
        }

        public void Limpiar()
        {
            _view.lblNombreApellido.Text = string.Empty;
            _view.lblDNI.Text = string.Empty;
            _view.dateFechaPago.Value = DateTime.Now;
            _view.dateDiaSeleccionado.Value = DateTime.Now;
            _view.lblTotalPagar.Text = string.Empty;
            ResetearRadioButtons();
            _view.actividadesSeleccionadas.Clear();
            _view.TotalPagar = 0;
            _view.ClienteSeleccionado = null;
            _view.dataGridResumen.Rows.Clear();
            _view.EstadoPagado = false;
            _view.btnPagar.Enabled = false;
            _view.btnComprobante.Enabled = false;
            _view.btnCalcular.Enabled = false;
            _view.lblBuscarStatus.Text = string.Empty;
            ResetearCheckBoxes();

            if (_actividades != null && _actividades.Count > 0)
            {
                _actividades.Clear();
            }
        }

        public void btnPagar_Click(object sender, EventArgs e)
        {
            if (_view.ClienteSeleccionado == null)
            {
                MessageBox.Show("Por favor, seleccione un cliente antes de realizar el pago.");
                return;
            }

            if (_view.TotalPagar <= 0)
            {
                MessageBox.Show("El monto a pagar debe ser mayor que cero.");
                return;
            }

            try
            {
                Pago pago = new Pago(
                    _view.ClienteSeleccionado.Id,
                    _view.TotalPagar,
                    _view.FormaPago,
                    _view.dateFechaPago.Value,
                    _view.dateDiaSeleccionado.Value,
                    null, // periodo_fin es null
                    false,  // socio_al_pagar es false
                    null // id_cuota no usado para no socios
                );

                PagoRepository pagoRepository = new PagoRepository();
                pagoRepository.RegistrarPago(pago);

                _view.EstadoPagado = true;

                MessageBox.Show("Pago registrado exitosamente.");

                _view.btnComprobante.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el pago: " + ex.Message);
            }
        }

        public void btnCalcular_Click(object sender, EventArgs e)
        {
            _view.btnComprobante.Enabled = false;

            // Actualizar los valores de descuento desde la base de datos
            var descuentosRepo = new DescuentosRepository();
            descuentosRepo.CargarDescuentos();

            // Obtener las actividades seleccionadas
            ObtenerActividadesSeleccionadas();

            // Verificar si hay actividades seleccionadas
            if (_view.actividadesSeleccionadas.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione al menos una actividad.");
                return;
            }

            // Validación apto -fisico: si "Gimnasio" está seleccionada y el cliente no tiene apto físico
            if (_view.actividadesSeleccionadas.Contains("Gimnasio") && _view.ClienteSeleccionado != null && !_view.ClienteSeleccionado.EsApto)
            {
                MessageBox.Show("El cliente no tiene el apto físico requerido para realizar actividades en el Gimnasio. Elija otra actividad/es.");
                return; // Detener la ejecución
            }

            // Obtener los precios de las actividades seleccionadas
            _actividades = _actividadRepository.ObtenerActividades().FindAll(a => _view.actividadesSeleccionadas.Contains(a.Nombre));

            // Calcular el total
            _view.TotalPagar = 0;
            foreach (var actividad in _actividades)
            {
                _view.TotalPagar += actividad.Precio;
            }

            // Usar DescuentoUtils para calcular el total con descuento aplicando los valores recién cargados
            var (totalConDescuento, montoDescuento) = DescuentoUtils.TotalDescuento(_view.TotalPagar, _view.FormaPago);

            // Mostrar el total actualizado
            _view.TotalPagar = totalConDescuento;
            _view.lblTotalPagar.Text = _view.TotalPagar.ToString("C2") + " $";

            // Cargar los datos en el DataGridView
            if (_actividades.Count > 0)
            {
                _actividades.Add(new Actividad { Nombre = "Descuento:", Precio = -montoDescuento });
            }
            CargarDataGridView(_actividades);

            _view.btnPagar.Enabled = true;
        }

        public void btnBuscar_Click(object sender, EventArgs e)
        {
            Limpiar();
            // Obtener el ID del cliente desde el TextBox
            if (int.TryParse(_view.txtClienteID.Text, out int clienteId))
            {
                // Crear una instancia del repositorio de clientes
                ClienteRepository clienteRepository = new ClienteRepository();

                try
                {
                    // Buscar el cliente por ID
                    Cliente? cliente = clienteRepository.BuscarClientePorId(clienteId);

                    if (cliente != null)
                    {
                        if (!cliente.EsSocio)
                        {
                            // Mostrar los datos del cliente en los labels
                            _view.lblNombreApellido.Text = $"{cliente.Nombre} {cliente.Apellido}";
                            _view.lblDNI.Text = cliente.Dni;

                            // Almacenar el cliente en la propiedad ClienteSeleccionado
                            _view.ClienteSeleccionado = cliente;
                            _view.btnCalcular.Enabled = true;
                            _view.lblBuscarStatus.Text = "Cliente encontrado con éxito";
                        }
                        else
                        {
                            _view.lblBuscarStatus.Text = "El cliente esta registrado como socio";
                            _view.btnCalcular.Enabled = false;
                        }
                    }
                    else
                    {
                        // Mostrar un mensaje de error si el cliente no se encuentra
                        MessageBox.Show("No se encontró un cliente con el ID proporcionado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar el cliente: " + ex.Message);
                }
            }
            else
            {
                // Mostrar un mensaje de error si el ID no es un número válido
                MessageBox.Show("Por favor, ingrese un ID de cliente válido.");
            }
        }

        public void radioEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (_view.radioEfectivo.Checked)
            {
                _view.FormaPago = "Efectivo";
            }
        }

        public void radioCuota3_CheckedChanged(object sender, EventArgs e)
        {
            if (_view.radioCuota3.Checked)
            {
                _view.FormaPago = "Tarjeta en 3 cuotas";
            }
        }

        public void radioCuota6_CheckedChanged(object sender, EventArgs e)
        {
            if (_view.radioCuota6.Checked)
            {
                _view.FormaPago = "Tarjeta en 6 cuotas";
            }
        }

        public void CargarActividadesEnDataGrid()
        {
            // Obtener las actividades desde el repositorio
            var actividades = _actividadRepository.ObtenerActividades();

            // Limpiar el DataGridView antes de cargar nuevos datos
            _view.dataGridSelecActi.Rows.Clear();

            // Iterar a través de las actividades y agregar filas al DataGridView
            foreach (var actividad in actividades)
            {
                _view.dataGridSelecActi.Rows.Add(false, actividad.Nombre, actividad.Precio);
            }
        }

        public void ObtenerActividadesSeleccionadas()
        {
            _view.actividadesSeleccionadas.Clear();

            // Iterar a través de las filas del DataGridView
            foreach (DataGridViewRow row in _view.dataGridSelecActi.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Seleccion"].Value))
                {
                    _view.actividadesSeleccionadas.Add(row.Cells["Nombre"].Value.ToString());
                }
            }
        }
    }
}

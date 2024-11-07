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
    public class RegistrarCuotaController : IPago, ILimpiezaForm
    {
        private readonly RegistrarCuota _view;

        public RegistrarCuotaController(RegistrarCuota view)
        {
            _view = view;
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
                DateTime periodoInicio = _view.dateDiaInicio.Value;
                DateTime periodoFin = periodoInicio.AddMonths(_view.MesesSeleccionados);
                periodoInicio = new DateTime(periodoInicio.Year, periodoInicio.Month, periodoInicio.Day, 0, 0, 0);


                PagoRepository pagoRepository = new PagoRepository();

                // Obtener la última fecha de periodo_fin registrada para el cliente
                DateTime? maxPeriodoFin = pagoRepository.ObtenerMaximoPeriodoFin(_view.ClienteSeleccionado.Id);

                // Validar que el nuevo periodoInicio sea posterior a la última fecha registrada
                if (maxPeriodoFin.HasValue && periodoInicio <= maxPeriodoFin.Value)
                {
                    MessageBox.Show("Error: El nuevo periodo de pago debe comenzar después de la última fecha registrada de pago del cliente: "+ maxPeriodoFin.Value.Date.ToString("d"));
                    return;
                }

                // Si la validación es exitosa, continuar con el registro del pago
                Pago pago = new Pago(
                    _view.ClienteSeleccionado.Id,
                    _view.TotalPagar,
                    _view.FormaPago,
                    _view.dateFechaPago.Value,
                    periodoInicio,
                    periodoFin,
                    true,  // socio_al_pagar es true
                    _view.TipoCuota // id_cuota
                );

                pagoRepository.RegistrarPago(pago);

                MessageBox.Show("Pago registrado exitosamente.");

                _view.btnComprobante.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el pago: " + ex.Message);
            }
        }





        public void btnComprobante_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado un cliente
            if (_view.ClienteSeleccionado != null)
            {
                // Guardar las ventanas abiertas en la lista, excluyendo la ventana de Login
                _view.ventanasAbiertas.Clear();
                foreach (Form form in Application.OpenForms)
                {
                    if (form != _view && !(form is Login)) // Omitimos la ventana actual y la ventana de Login
                    {
                        _view.ventanasAbiertas.Add(form);
                        form.Hide();
                    }
                }

                // Oculta la ventana actual (si es necesario)
                _view.Hide();

                // Obtener la fecha seleccionada en el DateTimePicker
                DateTime fechaPago = _view.dateFechaPago.Value;
                DateTime fechaInicio = _view.dateDiaInicio.Value;
                DateTime fechaFin = _view.CantidadMesesPagos;

                // Crea y muestra la ventana emergente
                Comprobante comprobante = new Comprobante(_view.ClienteSeleccionado, fechaPago, _view.FormaPago, _view.TotalPagar, _view.actividades, fechaInicio, fechaFin);
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

        public void btnCalcular_Click(object sender, EventArgs e)
        {
            // Crear una instancia del repositorio de descuentos y actualizar los valores desde la base de datos
            var descuentosRepo = new DescuentosRepository();
            descuentosRepo.CargarDescuentos();  // Actualiza los valores en ConfiguracionDescuentos

            // Crear una instancia del repositorio de cuotas
            CuotaSocioRepository cuotaSocioRepository = new CuotaSocioRepository();
            _view.TotalPagar = 0;
            _view.actividades.Clear();
            _view.btnComprobante.Enabled = false;

            // Actualizar la fecha de fin del periodo de acuerdo a la selección de meses
            _view.CantidadMesesPagos = _view.dateDiaInicio.Value.AddMonths(_view.MesesSeleccionados);

            try
            {
                // Obtener la cuota correspondiente al tipo de socio seleccionado
                Cuota cuota = cuotaSocioRepository.ObtenerCuotaPorId(_view.TipoCuota);

                if (cuota != null && cuota.Monto > 0)
                {
                    // Calcular el total a pagar
                    _view.TotalPagar = cuota.Monto * _view.MesesSeleccionados;
                    _view.actividades.Add(new Actividad { Nombre = "Cuota " + _view.comboBoxTipoSocio.Text, Precio = _view.TotalPagar });

                    // Aplicar el descuento usando los valores actualizados
                    var (totalConDescuento, montoDescuento) = DescuentoUtils.TotalDescuento(_view.TotalPagar, _view.FormaPago);

                    // Mostrar el total con descuento
                    _view.TotalPagar = totalConDescuento;
                    _view.lblTotalPagar.Text = _view.TotalPagar.ToString("C2") + " $";

                    if (_view.TotalPagar > 0)
                    {
                        _view.actividades.Add(new Actividad { Nombre = "Descuento:", Precio = -montoDescuento });
                    }

                    // Cargar los datos en el DataGridView
                    CargarDataGridView(_view.actividades);

                    _view.btnPagar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se encontró el tipo de socio seleccionado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular el precio a pagar: " + ex.Message);
            }
        }

        private void CargarDataGridView(List<Actividad> actividades)
        {
            // Limpiar el DataGridView antes de cargar nuevos datos
            _view.dataGridResumen.Rows.Clear();

            // Iterar a través de la lista de actividades y agregar filas al DataGridView
            foreach (var actividad in actividades)
            {
                _view.dataGridResumen.Rows.Add(actividad.Nombre, actividad.Precio);
            }
        }

        public void btnLimpiar_Click(object sender, EventArgs e)
        {
            _view.txtClienteID.Text = string.Empty;
            Limpiar();
        }

        private void Limpiar()
        {
            _view.lblNombreApellido.Text = string.Empty;
            _view.lblDNI.Text = string.Empty;
            _view.dateFechaPago.Value = DateTime.Now;
            _view.dateDiaInicio.Value = DateTime.Now;
            _view.lblTotalPagar.Text = string.Empty;
            ResetearRadioButtons();
            _view.btnPagar.Enabled = false;
            _view.btnComprobante.Enabled = false;
            _view.TotalPagar = 0;
            _view.ClienteSeleccionado = null;
            _view.dataGridResumen.Rows.Clear();
            _view.actividades.Clear();
            _view.comboBoxTipoSocio.SelectedIndex = 0;
            _view.comboBoxMesSus.SelectedIndex = 0;
            _view.MesesSeleccionados = 1;
            _view.btnCalcular.Enabled = false;
            _view.lblBuscarStatus.Text = string.Empty;
        }

        private void ResetearRadioButtons()
        {
            _view.radioEfectivo.Checked = true;
            // Restablecer el valor de la variable a su valor original
            _view.FormaPago = "Efectivo";
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
                        if (cliente.EsSocio)
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
                            _view.lblBuscarStatus.Text = "El cliente no esta registrado como socio";
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

        public void comboBoxTipoSocio_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Validar el índice seleccionado
            if (_view.comboBoxTipoSocio.SelectedIndex == 1) // Índice de "Premium"
            {
                _view.TipoCuota = 2;
            }
            else if (_view.comboBoxTipoSocio.SelectedIndex == 0) // Índice de "Regular"
            {
                _view.TipoCuota = 1;
            }
        }

        public void comboBoxMesSus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_view.comboBoxMesSus.SelectedItem != null)
            {
                _view.MesesSeleccionados = Convert.ToInt32(_view.comboBoxMesSus.SelectedItem.ToString());
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
    }
}

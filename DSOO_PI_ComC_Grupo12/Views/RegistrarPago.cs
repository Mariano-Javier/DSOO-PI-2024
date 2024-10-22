using DSOO_PI_ComC_Grupo12.Models;
using DSOO_PI_ComC_Grupo12.Repositories;
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
        public Cliente? ClienteSeleccionado { get; set; }
        public string FormaPago = "Efectivo";
        private List<Form> ventanasAbiertas;
        public List<string> actividadesSeleccionadas;
        private ActividadRepository actividadRepository;
        public Decimal TotalPagar;
        private bool EstadoPagado;
        public RegistrarPago()
        {
            InitializeComponent();
            ventanasAbiertas = new List<Form>();
            actividadesSeleccionadas = new List<string>();
            actividadRepository = new ActividadRepository();
            TotalPagar = 0;
            EstadoPagado = false;
        }

        private void ResetearRadioButtons()
        {
            radioEfectivo.Checked = true;
            // Restablecer el valor de la variable  a su valor original
            FormaPago = "Efectivo";
        }

        private void ResetearCheckBox()
        {
            checkBoxFutbol.CheckState = CheckState.Unchecked;
            checkBoxAcquagym.CheckState = CheckState.Unchecked;
            checkBoxBasket.CheckState = CheckState.Unchecked;
            checkBoxFutsal.CheckState = CheckState.Unchecked;
            checkBoxGimnasio.CheckState = CheckState.Unchecked;
            checkBoxNatacion.CheckState = CheckState.Unchecked;
            checkBoxNutricion.CheckState = CheckState.Unchecked;
            checkBoxPilates.CheckState = CheckState.Unchecked;
            checkBoxTenis.CheckState = CheckState.Unchecked;
            checkBoxVoley.CheckState = CheckState.Unchecked;
        }

        private void CargarDataGridView(Dictionary<string, decimal> preciosActividades)
        {
            // Limpiar el DataGridView antes de cargar nuevos datos
            dataGridResumen.Rows.Clear();

            // Iterar a través del diccionario y agregar filas al DataGridView
            foreach (var actividad in preciosActividades)
            {
                dataGridResumen.Rows.Add(actividad.Key, actividad.Value);
            }
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            if (EstadoPagado == false)
            {
                MessageBox.Show("Debe realizar el pago antes de poder emitir el comprobante.");
                return;
            }
            // Verificar si se ha seleccionado un cliente
            if (ClienteSeleccionado != null)
            {
                // Guardar las ventanas abiertas en la lista, excluyendo la ventana de Login
                ventanasAbiertas.Clear();
                foreach (Form form in Application.OpenForms)
                {
                    if (form != this && !(form is Login)) // Omitimos la ventana actual y la ventana de Login
                    {
                        ventanasAbiertas.Add(form);
                        form.Hide();
                    }
                }

                // Oculta la ventana actual (si es necesario)
                this.Hide();

                // Obtener la fecha seleccionada en el DateTimePicker
                DateTime fechaPago = dateFechaPago.Value;

                // Crea y muestra la ventana emergente
                Comprobante comprobante = new Comprobante(ClienteSeleccionado, fechaPago, FormaPago, TotalPagar);
                comprobante.ShowDialog(); // Mostrar como ventana modal

                // Cuando la ventana emergente se cierra, volvemos a mostrar todas las ventanas ocultas
                this.Show(); 
                foreach (Form form in ventanasAbiertas)
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtClienteID.Text = string.Empty;
            lblNombreApellido.Text = string.Empty;
            lblDNI.Text = string.Empty;
            dateFechaPago.Value = DateTime.Now;
            lblTotalPagar.Text = string.Empty;
            ResetearRadioButtons();
            ResetearCheckBox();
            actividadesSeleccionadas.Clear();
            TotalPagar = 0;
            ClienteSeleccionado = null;
            dataGridResumen.Rows.Clear();
            EstadoPagado = false;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            EstadoPagado = true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Obtener las actividades seleccionadas
            ObtenerCheckBoxesSeleccionados();

            // Verificar si hay actividades seleccionadas
            if (actividadesSeleccionadas.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione al menos una actividad.");
                return;
            }

            // Obtener los precios de las actividades seleccionadas
            Dictionary<string, decimal> preciosActividades = actividadRepository.ObtenerPreciosActividades(actividadesSeleccionadas);

            // Calcular el total
            TotalPagar = 0;
            foreach (var actividad in actividadesSeleccionadas)
            {
                if (preciosActividades.TryGetValue(actividad, out decimal precio))
                {
                    TotalPagar += precio;
                }
            }

            // Mostrar el total
            lblTotalPagar.Text = TotalPagar.ToString();

            // Cargar los datos en el DataGridView
            CargarDataGridView(preciosActividades);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Obtener el ID del cliente desde el TextBox
            if (int.TryParse(txtClienteID.Text, out int clienteId))
            {
                // Crear una instancia del repositorio de clientes
                ClienteRepository clienteRepository = new ClienteRepository();

                try
                {
                    // Buscar el cliente por ID
                    Cliente? cliente = clienteRepository.BuscarClientePorId(clienteId);

                    if (cliente != null)
                    {
                        // Mostrar los datos del cliente en los labels
                        lblNombreApellido.Text = $"{cliente.Nombre} {cliente.Apellido}";
                        lblDNI.Text = cliente.Dni;

                        // Almacenar el cliente en la propiedad ClienteSeleccionado
                        ClienteSeleccionado = cliente;
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

        private void radioEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioEfectivo.Checked)
            {
                FormaPago = "Efectivo";
            }
        }

        private void radioCuota3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCuota3.Checked)
            {
                FormaPago = "Tarjeta en 3 cuotas";
            }
        }

        private void radioCuota6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCuota6.Checked)
            {
                FormaPago = "Tarjeta en 6 cuotas";
            }
        }

        private void ObtenerCheckBoxesSeleccionados()
        {
            actividadesSeleccionadas.Clear();
            // Diccionario para mapear los checkboxes con sus valores string
            Dictionary<CheckBox, string> actividades = new Dictionary<CheckBox, string>()
        {
            { checkBoxFutbol, "Fútbol" },
            { checkBoxVoley, "Voley" },
            { checkBoxNatacion, "Natación" },
            { checkBoxGimnasio, "Gimnasio" },
            { checkBoxPilates, "Pilates" },
            { checkBoxFutsal, "Futsal" },
            { checkBoxBasket, "Basket" },
            { checkBoxTenis, "Tenis" },
            { checkBoxAcquagym, "Acquagym" },
            { checkBoxNutricion, "Nutrición" }
        };

            // Iterar a través del diccionario para ver qué checkboxes están seleccionados
            foreach (var actividad in actividades)
            {
                if (actividad.Key.Checked) // Si el checkbox está marcado
                {
                    actividadesSeleccionadas.Add(actividad.Value); // Añadir la actividad seleccionada a la lista
                }
            }

        }
    }
}

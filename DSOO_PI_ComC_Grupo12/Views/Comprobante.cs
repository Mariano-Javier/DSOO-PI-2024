using DSOO_PI_ComC_Grupo12.Models;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSOO_PI_ComC_Grupo12.Views
{
    public partial class Comprobante : Form
    {
        private Cliente? Cliente { get; set; }
        private DateTime FechaPago { get; set; }
        private DateTime FechaInicio { get; set; }

        public Comprobante(Cliente cliente, DateTime fechaPago, String FormaPago, Decimal TotalPagar, Dictionary<String, decimal> preciosActividades, DateTime fechaInicio)
        {
            InitializeComponent();
            Cliente = cliente;
            FechaPago = fechaPago;
            FechaInicio = fechaInicio; 

            lblNombreApellido.Text = $"{cliente.Nombre} {cliente.Apellido}";
            lblDNI.Text = cliente.Dni;
            lblFechaPago.Text = fechaPago.ToString("dd/MM/yyyy");
            lblFormaPago.Text = FormaPago;
            lblTotal.Text = TotalPagar.ToString() + " $";

            dataGridResumen.DefaultCellStyle.SelectionBackColor = Color.White;
            dataGridResumen.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridFechas.DefaultCellStyle.SelectionBackColor = Color.White;
            dataGridFechas.DefaultCellStyle.SelectionForeColor = Color.Black;

            CargarDataGridView(preciosActividades);
            printComprobante.PrintPage += new PrintPageEventHandler(printComprobante_PrintPage);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //modificar: poner en una clase estatica:-> RegistrarPago y Comprobante
        private void CargarDataGridView(Dictionary<string, decimal> preciosActividades)
        {
            // Limpiar el DataGridView antes de cargar nuevos datos
            dataGridResumen.Rows.Clear();
            dataGridFechas.Rows.Clear();

            // Iterar a través del diccionario y agregar filas al DataGridView
            foreach (var actividad in preciosActividades)
            {
                dataGridResumen.Rows.Add(actividad.Key, actividad.Value);
            }

            dataGridFechas.Rows.Add(FechaInicio.ToString("dd/MM/yyyy"), "Válido solo por el día abonado");
        }
        //----------------------------------IMPRESION----------------------------------
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printComprobante;

            // Muestra el diálogo de impresión
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Imprime el documento
                printComprobante.Print();
            }
        }
        private void printComprobante_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Define la resolución deseada (por ejemplo, 96 DPI)
            int dpi = 96;

            // Calcula el tamaño del panel en píxeles a la resolución deseada
            int width = panelComprobante.Width;
            int height = panelComprobante.Height;

            // Crea una imagen del panel con la resolución deseada
            Bitmap bmp = new Bitmap(width, height);
            bmp.SetResolution(dpi, dpi);

            // Dibuja el contenido del panel en el Bitmap
            panelComprobante.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));

            // Calcula el tamaño de la página en píxeles
            float pageWidth = e.PageBounds.Width;
            float pageHeight = e.PageBounds.Height;

            // Calcula el factor de escala para ajustar la imagen al tamaño de la página
            float scale = Math.Min(pageWidth / bmp.Width, pageHeight / bmp.Height);

            // Calcula el tamaño de la imagen escalada
            int scaledWidth = (int)(bmp.Width * scale);
            int scaledHeight = (int)(bmp.Height * scale);

            // Calcula la posición de la imagen escalada para centrarla en la página
            int x = (int)((pageWidth - scaledWidth) / 2);
            int y = (int)((pageHeight - scaledHeight) / 2);

            // Dibuja la imagen en el área de impresión
            e.Graphics.DrawImage(bmp, x, y, scaledWidth, scaledHeight);

            // Libera los recursos de la imagen
            bmp.Dispose();
        }
        //------------------------------FIN-IMPRESION----------------------------------
    }
}

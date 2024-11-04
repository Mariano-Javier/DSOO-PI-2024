using DSOO_PI_ComC_Grupo12.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace DSOO_PI_ComC_Grupo12.Controllers
{
    public class ComprobanteController
    {
        public void CargarDataGridViewNS(List<Actividad> actividades, DataGridView dataGridResumen, DataGridView dataGridFechas, DateTime fechaInicio)
        {
            // Limpiar el DataGridView antes de cargar nuevos datos
            dataGridResumen.Rows.Clear();
            dataGridFechas.Rows.Clear();

            // Iterar a través de la lista de actividades y agregar filas al DataGridView
            foreach (var actividad in actividades)
            {
                dataGridResumen.Rows.Add(actividad.Nombre, actividad.Precio);
            }

            dataGridFechas.Rows.Add(fechaInicio.ToString("dd/MM/yyyy"), "Válido solo por el día abonado");
        }

        public void CargarDataGridViewS(List<Actividad> actividades, DataGridView dataGridResumen, DataGridView dataGridFechas, DateTime fechaInicio, DateTime fechaFin)
        {
            // Limpiar el DataGridView antes de cargar nuevos datos
            dataGridResumen.Rows.Clear();
            dataGridFechas.Rows.Clear();

            // Iterar a través de la lista de actividades y agregar filas al DataGridView
            foreach (var actividad in actividades)
            {
                dataGridResumen.Rows.Add(actividad.Nombre, actividad.Precio);
            }

            dataGridFechas.Rows.Add(fechaInicio.ToString("dd/MM/yyyy"), fechaFin.ToString("dd/MM/yyyy"));
        }

        public void ImprimirComprobante(Panel panelComprobante, PrintDocument printComprobante)
        {
            printComprobante.PrintPage += new PrintPageEventHandler((sender, e) =>
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
            });
        }
    }
}

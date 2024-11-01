using System;
using System.Windows.Forms;
using DSOO_PI_ComC_Grupo12.Repositories;

namespace DSOO_PI_ComC_Grupo12
{
    internal static class Program
    {
        /// <summary>
        /// La aplicación simula administrar los usuarios de un club deportivo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Cargar descuentos desde la base de datos al iniciar la aplicación
            try
            {
                var descuentosRepo = new DescuentosRepository();
                descuentosRepo.CargarDescuentos(); // Carga los valores en ConfiguracionDescuentos
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la configuración de descuentos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Finaliza si no se pueden cargar los descuentos
            }

            // Configuración de la aplicación de Windows Forms
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Views.Login());
        }
    }
}

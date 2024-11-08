using System;
using System.Windows.Forms;
using DSOO_PI_ComC_Grupo12.Repositories;
using DSOO_PI_ComC_Grupo12.Config;

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
            // Configuración de la aplicación de Windows Forms
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Views.Login());
        }
    }
}

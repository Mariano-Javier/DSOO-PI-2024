using DSOO_PI_ComC_Grupo12.Config;
using DSOO_PI_ComC_Grupo12.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSOO_PI_ComC_Grupo12.Helpers
{
    public static class DatabaseConfigurationHelper
    {
        public static bool CargarConfiguracionBD()
        {
            try
            {
                ConfiguracionBD.CargarConfiguracion();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la configuración de la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public static bool CargarDescuentos()
        {
            try
            {
                var descuentosRepo = new DescuentosRepository();
                descuentosRepo.CargarDescuentos(); // Carga los valores en ConfiguracionDescuentos
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la configuración de la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}

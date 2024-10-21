using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSOO_PI_ComC_Grupo12.Config
{
    public static class ConfiguracionBD
    {
        // Variables estáticas para la configuración de la base de datos
        public static string NombreBase { get; set; } = "grupo12_comc_test";
        public static string Servidor { get; set; } = "localhost";
        public static string Puerto { get; set; } = "3306";
        public static string Usuario { get; set; } = "root";
        public static string Contrasenia { get; set; } = "12345678";
    }
}

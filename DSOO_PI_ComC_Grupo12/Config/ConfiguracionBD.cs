using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace DSOO_PI_ComC_Grupo12.Config
{
    public static class ConfiguracionBD
    {
        // Variables estáticas para la configuración de la base de datos
        public static string NombreBase { get; set; } = "grupo12_comc_club";
        public static string Servidor { get; set; } = "localhost";
        public static string Puerto { get; set; } = "3306";
        public static string Usuario { get; set; } = "root";
        public static string Contrasenia { get; set; } = "12345678";

        private static string ConfigFilePath => Path.Combine(Application.StartupPath, "config.json");

        public static void GuardarConfiguracion()
        {
            var config = new
            {
                NombreBase,
                Servidor,
                Puerto,
                Usuario,
                Contrasenia
            };

            var json = JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(ConfigFilePath, json);
        }

        public static void CargarConfiguracion()
        {
            if (File.Exists(ConfigFilePath))
            {
                var json = File.ReadAllText(ConfigFilePath);
                var config = JsonSerializer.Deserialize<JsonDocument>(json).RootElement;

                NombreBase = config.GetProperty("NombreBase").GetString();
                Servidor = config.GetProperty("Servidor").GetString();
                Puerto = config.GetProperty("Puerto").GetString();
                Usuario = config.GetProperty("Usuario").GetString();
                Contrasenia = config.GetProperty("Contrasenia").GetString();
            }
        }
    }
}

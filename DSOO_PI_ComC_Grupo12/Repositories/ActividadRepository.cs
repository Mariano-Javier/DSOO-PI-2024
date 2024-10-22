using DSOO_PI_ComC_Grupo12.Config;
using DSOO_PI_ComC_Grupo12.Services;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace DSOO_PI_ComC_Grupo12.Repositories
{
    internal class ActividadRepository
    {
        public Dictionary<string, decimal> ObtenerPreciosActividades(List<string> actividades)
        {
            Dictionary<string, decimal> precios = new Dictionary<string, decimal>();
            MySqlConnection? conexionDb = null;

            try
            {
                conexionDb = Conexion.getInstancia(
                    ConfiguracionBD.NombreBase,
                    ConfiguracionBD.Servidor,
                    ConfiguracionBD.Puerto,
                    ConfiguracionBD.Usuario,
                    ConfiguracionBD.Contrasenia).CrearConexion();
                conexionDb.Open();

                using (MySqlCommand comando = new MySqlCommand())
                {
                    comando.Connection = conexionDb;
                    comando.CommandText = "SELECT nombre, precio FROM actividad WHERE nombre IN (@actividades)";

                    // Crear una cadena de parámetros para la consulta
                    string parametros = string.Join(",", actividades.ConvertAll(a => $"'{a}'"));
                    comando.CommandText = comando.CommandText.Replace("@actividades", parametros);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nombre = reader.GetString(0);
                            decimal precio = reader.GetDecimal(1);
                            precios[nombre] = precio;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener precios de actividades: " + ex.Message);
            }
            finally
            {
                if (conexionDb != null && conexionDb.State == System.Data.ConnectionState.Open)
                {
                    conexionDb.Close();
                }
            }

            return precios;
        }

    }
}

using MySql.Data.MySqlClient;
using System;
using DSOO_PI_ComC_Grupo12.Helpers;
using DSOO_PI_ComC_Grupo12.Models;

namespace DSOO_PI_ComC_Grupo12.Repositories
{
    internal class AutenticacionRepository : BaseRepository
    {
        public Empleado AutenticarUsuario(string usuario, string contrasenia)
        {
            MySqlConnection conexionDb = null;

            try
            {
                conexionDb = ObtenerConexion();

                using (var comando = new MySqlCommand())
                {
                    comando.Connection = conexionDb;
                    comando.CommandText = "SELECT id, nombre, apellido, dni, email, telefono, fecha_nac, rol FROM empleado WHERE usuario = @usuario AND contrasenia = @contrasenia";
                    comando.Parameters.AddWithValue("@usuario", usuario);
                    comando.Parameters.AddWithValue("@contrasenia", contrasenia);

                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Empleado(
                                reader.GetInt32("id"),
                                reader.GetString("nombre"),
                                reader.GetString("apellido"),
                                reader.GetString("dni"),
                                reader.GetString("email"),
                                reader.GetString("telefono"),
                                reader.GetDateTime("fecha_nac"),
                                reader.GetString("rol"),
                                usuario,
                                contrasenia
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al autenticar el usuario: " + ex.Message);
            }
            finally
            {
                CerrarConexion(conexionDb);
            }

            return null; // Retorna null si el usuario no fue autenticado
        }
    }
}

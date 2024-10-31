using MySql.Data.MySqlClient;
using System;
using DSOO_PI_ComC_Grupo12.Helpers;

namespace DSOO_PI_ComC_Grupo12.Repositories
{
    internal class AutenticacionRepository : BaseRepository
    {
        public bool AutenticarUsuario(string usuario, string contrasenia, out string nombre, out string apellido, out string email, out string rol)
        {
            // Inicializar los valores de salida
            nombre = string.Empty;
            apellido = string.Empty;
            email = string.Empty;
            rol = string.Empty;

            MySqlConnection conexionDb = null;

            try
            {
                conexionDb = ObtenerConexion();

                using (var comando = new MySqlCommand())
                {
                    comando.Connection = conexionDb;
                    comando.CommandText = "SELECT nombre, apellido, email, rol FROM empleado WHERE usuario = @usuario AND contrasenia = @contrasenia";
                    comando.Parameters.AddWithValue("@usuario", usuario);
                    comando.Parameters.AddWithValue("@contrasenia", contrasenia);

                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            nombre = reader["nombre"].ToString();
                            apellido = reader["apellido"].ToString();
                            email = reader["email"].ToString();
                            rol = reader["rol"].ToString();
                            return true;
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

            return false; // Retorna false si el usuario no fue autenticado
        }
    }
}

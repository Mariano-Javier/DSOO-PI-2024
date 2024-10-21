using DSOO_PI_ComC_Grupo12.Config;
using DSOO_PI_ComC_Grupo12.Services;
using MySql.Data.MySqlClient;
using System;

namespace DSOO_PI_ComC_Grupo12.Repositories
{
    internal class AutenticacionRepository
    {
        public bool AutenticarUsuario(string usuario, string contrasenia, out string nombre, out string apellido, out string email, out string rol)
        {
            nombre = string.Empty;
            apellido = string.Empty;
            email = string.Empty;
            rol = string.Empty;

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

                using (MySqlCommand mySqlCommand = new MySqlCommand())
                {
                    mySqlCommand.Connection = conexionDb;
                    mySqlCommand.CommandText = "SELECT nombre, apellido, email, rol FROM empleado WHERE usuario = @usuario AND contrasenia = @contrasenia";
                    mySqlCommand.Parameters.AddWithValue("@usuario", usuario);
                    mySqlCommand.Parameters.AddWithValue("@contrasenia", contrasenia);

                    using (MySqlDataReader leer = mySqlCommand.ExecuteReader())
                    {
                        if (leer.Read())
                        {
                            nombre = leer["nombre"].ToString();
                            apellido = leer["apellido"].ToString();
                            email = leer["email"].ToString();
                            rol = leer["rol"].ToString();
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al conectar con la base de datos: " + ex.Message);
            }
            finally
            {
                if (conexionDb != null && conexionDb.State == System.Data.ConnectionState.Open)
                {
                    conexionDb.Close();
                }
            }
            return false;
        }
    }
}

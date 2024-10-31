using MySql.Data.MySqlClient;
using System;
using DSOO_PI_ComC_Grupo12.Models;
using DSOO_PI_ComC_Grupo12.Helpers;

namespace DSOO_PI_ComC_Grupo12.Repositories
{
    internal class EmpleadoRepository : BaseRepository
    {
        public bool ExisteUsuario(string usuario)
        {
            MySqlConnection conexionDb = null;
            try
            {
                conexionDb = ObtenerConexion();

                using (var comando = new MySqlCommand())
                {
                    comando.Connection = conexionDb;
                    comando.CommandText = "SELECT COUNT(*) FROM empleado WHERE usuario = @usuario";
                    comando.Parameters.AddWithValue("@usuario", usuario);
                    int cantidad = Convert.ToInt32(comando.ExecuteScalar());
                    return cantidad > 0;  // Devuelve true si el usuario ya existe
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar usuario: " + ex.Message);
            }
            finally
            {
                CerrarConexion(conexionDb);
            }
        }

        public long RegistrarEmpleado(Empleado empleado)
        {
            MySqlConnection conexionDb = null;
            try
            {
                conexionDb = ObtenerConexion();

                using (var comando = new MySqlCommand())
                {
                    comando.Connection = conexionDb;
                    comando.CommandText = @"INSERT INTO empleado
                                            (nombre, apellido, dni, email, telefono, fecha_nac, rol, usuario, contrasenia)
                                            VALUES (@nombre, @apellido, @dni, @email, @telefono, @fecha_nac, @rol, @usuario, @contrasenia)";

                    comando.Parameters.AddWithValue("@nombre", empleado.Nombre);
                    comando.Parameters.AddWithValue("@apellido", empleado.Apellido);
                    comando.Parameters.AddWithValue("@dni", empleado.Dni);
                    comando.Parameters.AddWithValue("@email", empleado.Email);
                    comando.Parameters.AddWithValue("@telefono", empleado.Telefono);
                    comando.Parameters.AddWithValue("@fecha_nac", empleado.FechaNacimiento);
                    comando.Parameters.AddWithValue("@rol", empleado.Rol);
                    comando.Parameters.AddWithValue("@usuario", empleado.Usuario);
                    comando.Parameters.AddWithValue("@contrasenia", empleado.Contrasenia);

                    int filasAfectadas = comando.ExecuteNonQuery();
                    return filasAfectadas > 0 ? comando.LastInsertedId : -1; // Devuelve el ID insertado o -1 si no se insertó
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar empleado: " + ex.Message);
            }
            finally
            {
                CerrarConexion(conexionDb);
            }
        }        
    }
}

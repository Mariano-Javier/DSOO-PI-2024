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
            catch (MySqlException ex)
            {
                // Manejo específico de MySqlException
                switch (ex.Number)
                {
                    case 1042: // No se puede conectar al servidor MySQL
                        throw new Exception("No se pudo conectar al servidor MySQL. Verifica que el servicio esté en funcionamiento.");
                    case 1045: // Error de autenticación
                        throw new Exception("Acceso denegado. Verifica el usuario y la contraseña de la base de datos.");
                    default:
                        throw new Exception($"Error de MySQL ({ex.Number}): {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                // Captura de cualquier otra excepción
                throw new Exception($"Error al verificar usuario: {ex.Message}");
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
            catch (MySqlException ex)
            {
                // Manejo específico de MySqlException
                switch (ex.Number)
                {
                    case 1062: // Duplicación de clave primaria (usuario ya existe)
                        throw new Exception("Error al registrar empleado: el usuario ya existe.");
                    case 1042: // No se puede conectar al servidor MySQL
                        throw new Exception("No se pudo conectar al servidor MySQL. Verifica que el servicio esté en funcionamiento.");
                    case 1045: // Error de autenticación
                        throw new Exception("Acceso denegado. Verifica el usuario y la contraseña de la base de datos.");
                    default:
                        throw new Exception($"Error de MySQL ({ex.Number}): {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                // Captura de cualquier otra excepción
                throw new Exception($"Error al registrar empleado: {ex.Message}");
            }
            finally
            {
                CerrarConexion(conexionDb);
            }
        }
    }
}

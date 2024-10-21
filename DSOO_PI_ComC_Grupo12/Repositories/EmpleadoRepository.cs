using DSOO_PI_ComC_Grupo12.Config;
using DSOO_PI_ComC_Grupo12.Models;
using DSOO_PI_ComC_Grupo12.Services;
using MySql.Data.MySqlClient;
using System;

namespace DSOO_PI_ComC_Grupo12.Repositories
{
    internal class EmpleadoRepository
    {
        public bool ExisteUsuario(string usuario)
        {
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
                    comando.CommandText = "SELECT COUNT(*) FROM empleado WHERE usuario = @usuario";
                    comando.Parameters.AddWithValue("@usuario", usuario);
                    int cantidad = Convert.ToInt32(comando.ExecuteScalar());
                    return cantidad > 0;  // Si el conteo es mayor a 0, ya existe un empleado con ese usuario
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar usuario: " + ex.Message);
            }
            finally
            {
                if (conexionDb != null && conexionDb.State == System.Data.ConnectionState.Open)
                {
                    conexionDb.Close();
                }
            }
        }

        public long RegistrarEmpleado(Empleado empleado)
        {
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
                    if (filasAfectadas > 0)
                    {
                        return comando.LastInsertedId;
                    }
                    else
                    {
                        return -1; // Indica que no se insertó ningún registro
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar empleado: " + ex.Message);
            }
            finally
            {
                if (conexionDb != null && conexionDb.State == System.Data.ConnectionState.Open)
                {
                    conexionDb.Close();
                }
            }
        }
    }
}

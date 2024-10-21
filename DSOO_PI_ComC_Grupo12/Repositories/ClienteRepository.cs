using DSOO_PI_ComC_Grupo12.Config;
using DSOO_PI_ComC_Grupo12.Models;
using DSOO_PI_ComC_Grupo12.Services;
using MySql.Data.MySqlClient;
using System;

namespace DSOO_PI_ComC_Grupo12.Repositories
{
    internal class ClienteRepository
    {
        public bool ExisteDni(string dni)
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
                    comando.CommandText = "SELECT COUNT(*) FROM cliente WHERE dni = @dni";
                    comando.Parameters.AddWithValue("@dni", dni);
                    int cantidad = Convert.ToInt32(comando.ExecuteScalar());
                    return cantidad > 0;  // Si el conteo es mayor a 0, ya existe un cliente con ese DNI
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar DNI: " + ex.Message);
            }
            finally
            {
                if (conexionDb != null && conexionDb.State == System.Data.ConnectionState.Open)
                {
                    conexionDb.Close();
                }
            }
        }

        public long RegistrarCliente(Cliente cliente)
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
                    comando.CommandText = @"INSERT INTO cliente
                (nombre, apellido, dni, email, telefono, fecha_nac, es_socio, es_apto)
                VALUES (@nombre, @apellido, @dni, @email, @telefono, @fecha_nac, @es_socio, @es_apto)";

                    comando.Parameters.AddWithValue("@nombre", cliente.Nombre);
                    comando.Parameters.AddWithValue("@apellido", cliente.Apellido);
                    comando.Parameters.AddWithValue("@dni", cliente.Dni);
                    comando.Parameters.AddWithValue("@email", cliente.Email);
                    comando.Parameters.AddWithValue("@telefono", cliente.Telefono);
                    comando.Parameters.AddWithValue("@fecha_nac", cliente.FechaNacimiento);
                    comando.Parameters.AddWithValue("@es_socio", cliente.EsSocio);
                    comando.Parameters.AddWithValue("@es_apto", cliente.EsApto);

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
                throw new Exception("Error al registrar cliente: " + ex.Message);
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

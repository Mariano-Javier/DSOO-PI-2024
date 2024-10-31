using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using DSOO_PI_ComC_Grupo12.Models;
using DSOO_PI_ComC_Grupo12.DTO;
using DSOO_PI_ComC_Grupo12.Helpers;

namespace DSOO_PI_ComC_Grupo12.Repositories
{
    internal class ClienteRepository : BaseRepository
    {
        public bool ExisteDni(string dni)
        {
            MySqlConnection conexionDb = null;
            try
            {
                conexionDb = ObtenerConexion();

                using (var comando = new MySqlCommand())
                {
                    comando.Connection = conexionDb;
                    comando.CommandText = "SELECT COUNT(*) FROM cliente WHERE dni = @dni";
                    comando.Parameters.AddWithValue("@dni", dni);
                    int cantidad = Convert.ToInt32(comando.ExecuteScalar());
                    return cantidad > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar DNI: " + ex.Message);
            }
            finally
            {
                CerrarConexion(conexionDb);
            }
        }

        public long RegistrarCliente(Cliente cliente)
        {
            MySqlConnection conexionDb = null;
            try
            {
                conexionDb = ObtenerConexion();

                using (var comando = new MySqlCommand())
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
                    return filasAfectadas > 0 ? comando.LastInsertedId : -1;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar cliente: " + ex.Message);
            }
            finally
            {
                CerrarConexion(conexionDb);
            }
        }

        public Cliente? BuscarClientePorId(int clienteId)
        {
            MySqlConnection conexionDb = null;
            try
            {
                conexionDb = ObtenerConexion();

                using (var comando = new MySqlCommand())
                {
                    comando.Connection = conexionDb;
                    comando.CommandText = @"SELECT id, nombre, apellido, dni, email, telefono, fecha_nac, es_socio, es_apto
                                            FROM cliente
                                            WHERE id = @id";
                    comando.Parameters.AddWithValue("@id", clienteId);

                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Cliente(
                                id: reader.GetInt32(0),
                                nombre: reader.GetString(1),
                                apellido: reader.GetString(2),
                                dni: reader.GetString(3),
                                mail: reader.GetString(4),
                                telefono: reader.GetString(5),
                                fechaNacimiento: reader.GetDateTime(6),
                                esSocio: reader.GetBoolean(7),
                                esApto: reader.GetBoolean(8)
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar cliente: " + ex.Message);
            }
            finally
            {
                CerrarConexion(conexionDb);
            }
            return null;
        }

        public Cliente? BuscarClientePorDni(string dni)
        {
            MySqlConnection conexionDb = null;
            try
            {
                conexionDb = ObtenerConexion();

                using (var comando = new MySqlCommand())
                {
                    comando.Connection = conexionDb;
                    comando.CommandText = @"SELECT id, nombre, apellido, dni, email, telefono, fecha_nac, es_socio, es_apto
                                            FROM cliente
                                            WHERE dni = @dni";
                    comando.Parameters.AddWithValue("@dni", dni);

                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Cliente(
                                id: reader.GetInt32(0),
                                nombre: reader.GetString(1),
                                apellido: reader.GetString(2),
                                dni: reader.GetString(3),
                                mail: reader.GetString(4),
                                telefono: reader.GetString(5),
                                fechaNacimiento: reader.GetDateTime(6),
                                esSocio: reader.GetBoolean(7),
                                esApto: reader.GetBoolean(8)
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar cliente: " + ex.Message);
            }
            finally
            {
                CerrarConexion(conexionDb);
            }
            return null;
        }

        public List<SocioConPagoDTO> ObtenerSociosConPagos()
        {
            var socios = new List<SocioConPagoDTO>();
            MySqlConnection conexionDb = null;

            try
            {
                conexionDb = ObtenerConexion();

                using (var comando = new MySqlCommand())
                {
                    comando.Connection = conexionDb;
                    comando.CommandText = @"SELECT c.id, c.nombre, c.apellido, c.email, c.telefono, p.periodo_fin
                                            FROM cliente c
                                            JOIN (SELECT id_cliente, MAX(periodo_fin) AS periodo_fin
                                                  FROM pago
                                                  GROUP BY id_cliente) p 
                                                  ON c.id = p.id_cliente
                                            WHERE c.es_socio = true";

                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            socios.Add(new SocioConPagoDTO
                            {
                                Id = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                Apellido = reader.GetString(2),
                                Email = reader.GetString(3),
                                Telefono = reader.GetString(4),
                                PeriodoFin = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5)
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener socios con pagos: " + ex.Message);
            }
            finally
            {
                CerrarConexion(conexionDb);
            }

            return socios;
        }

        public List<SocioConPagoDTO> ObtenerSociosConCuotaVencidaHoy()
        {
            var socios = new List<SocioConPagoDTO>();
            MySqlConnection conexionDb = null;

            try
            {
                conexionDb = ObtenerConexion();

                using (var comando = new MySqlCommand())
                {
                    comando.Connection = conexionDb;
                    comando.CommandText = @"
                        SELECT c.id, c.nombre, c.apellido, c.email, c.telefono, p.periodo_fin
                        FROM cliente c
                        JOIN (
                            SELECT id_cliente, MAX(periodo_fin) AS periodo_fin
                            FROM pago
                            GROUP BY id_cliente
                        ) p ON c.id = p.id_cliente
                        WHERE c.es_socio = true AND p.periodo_fin = @fecha_hoy";

                    comando.Parameters.AddWithValue("@fecha_hoy", DateTime.Now.Date);

                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            socios.Add(new SocioConPagoDTO
                            {
                                Id = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                Apellido = reader.GetString(2),
                                Email = reader.GetString(3),
                                Telefono = reader.GetString(4),
                                PeriodoFin = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5)
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener socios con cuota vencida hoy: " + ex.Message);
            }
            finally
            {
                CerrarConexion(conexionDb);
            }

            return socios;
        }

        public List<SocioConPagoDTO> ObtenerSociosConCuotaVencida()
        {
            var socios = new List<SocioConPagoDTO>();
            MySqlConnection conexionDb = null;

            try
            {
                conexionDb = ObtenerConexion();

                using (var comando = new MySqlCommand())
                {
                    comando.Connection = conexionDb;
                    comando.CommandText = @"
                        SELECT c.id, c.nombre, c.apellido, c.email, c.telefono, p.periodo_fin
                        FROM cliente c
                        JOIN (
                            SELECT id_cliente, MAX(periodo_fin) AS periodo_fin
                            FROM pago
                            GROUP BY id_cliente
                        ) p ON c.id = p.id_cliente
                        WHERE c.es_socio = true AND p.periodo_fin < @fecha_hoy";

                    comando.Parameters.AddWithValue("@fecha_hoy", DateTime.Now.Date);

                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            socios.Add(new SocioConPagoDTO
                            {
                                Id = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                Apellido = reader.GetString(2),
                                Email = reader.GetString(3),
                                Telefono = reader.GetString(4),
                                PeriodoFin = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5)
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener socios con cuota vencida: " + ex.Message);
            }
            finally
            {
                CerrarConexion(conexionDb);
            }

            return socios;
        }

        public bool ActualizarCliente(Cliente cliente)
        {
            MySqlConnection conexionDb = null;
            try
            {
                conexionDb = ObtenerConexion();

                using (var comando = new MySqlCommand())
                {
                    comando.Connection = conexionDb;
                    comando.CommandText = @"UPDATE cliente
                                            SET nombre = @nombre,
                                                apellido = @apellido,
                                                dni = @dni,
                                                email = @email,
                                                telefono = @telefono,
                                                fecha_nac = @fecha_nac,
                                                es_socio = @es_socio,
                                                es_apto = @es_apto
                                            WHERE id = @id";

                    comando.Parameters.AddWithValue("@id", cliente.Id);
                    comando.Parameters.AddWithValue("@nombre", cliente.Nombre);
                    comando.Parameters.AddWithValue("@apellido", cliente.Apellido);
                    comando.Parameters.AddWithValue("@dni", cliente.Dni);
                    comando.Parameters.AddWithValue("@email", cliente.Email);
                    comando.Parameters.AddWithValue("@telefono", cliente.Telefono);
                    comando.Parameters.AddWithValue("@fecha_nac", cliente.FechaNacimiento);
                    comando.Parameters.AddWithValue("@es_socio", cliente.EsSocio);
                    comando.Parameters.AddWithValue("@es_apto", cliente.EsApto);

                    int filasAfectadas = comando.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar cliente: " + ex.Message);
            }
            finally
            {
                CerrarConexion(conexionDb);
            }
        }
    }
}

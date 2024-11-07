using MySql.Data.MySqlClient;
using System;
using DSOO_PI_ComC_Grupo12.Helpers;
using DSOO_PI_ComC_Grupo12.Models;

namespace DSOO_PI_ComC_Grupo12.Repositories
{
    internal class PagoRepository : BaseRepository
    {
        public void RegistrarPago(Pago pago)
        {
            MySqlConnection conexionDb = null;

            try
            {
                conexionDb = ObtenerConexion();

                using (var comando = new MySqlCommand())
                {
                    comando.Connection = conexionDb;
                    comando.CommandText = @"INSERT INTO pago
                                            (id_cliente, monto, medio_de_pago, fecha_pago, periodo_inicio, periodo_fin, socio_al_pagar, id_cuota)
                                            VALUES (@idCliente, @monto, @medioPago, @fechaPago, @periodoInicio, @periodoFin, @socioAlPagar, @idCuota)";

                    comando.Parameters.AddWithValue("@idCliente", pago.IdCliente);
                    comando.Parameters.AddWithValue("@monto", pago.Monto);
                    comando.Parameters.AddWithValue("@medioPago", pago.MedioDePago);
                    comando.Parameters.AddWithValue("@fechaPago", pago.FechaPago);
                    comando.Parameters.AddWithValue("@periodoInicio", pago.PeriodoInicio);
                    comando.Parameters.AddWithValue("@periodoFin", pago.PeriodoFin ?? (object)DBNull.Value);
                    comando.Parameters.AddWithValue("@socioAlPagar", pago.SocioAlPagar);
                    comando.Parameters.AddWithValue("@idCuota", pago.IdCuota ?? (object)DBNull.Value);

                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar el pago: " + ex.Message);
            }
            finally
            {
                CerrarConexion(conexionDb);
            }
        }

        public bool ClienteHaPagado(int clienteId)
        {
            MySqlConnection conexionDb = null;
            try
            {
                conexionDb = ObtenerConexion();

                using (var comando = new MySqlCommand())
                {
                    comando.Connection = conexionDb;
                    comando.CommandText = "SELECT COUNT(*) FROM pago WHERE id_cliente = @id_cliente";
                    comando.Parameters.AddWithValue("@id_cliente", clienteId);

                    int cantidad = Convert.ToInt32(comando.ExecuteScalar());
                    return cantidad > 0;  // Si el conteo es mayor a 0, el cliente ha realizado al menos un pago
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar pagos del cliente: " + ex.Message);
            }
            finally
            {
                CerrarConexion(conexionDb);
            }
        }

        public DateTime? ObtenerPeriodoFin(int clienteId)
        {
            MySqlConnection conexionDb = null;
            try
            {
                conexionDb = ObtenerConexion();

                using (var comando = new MySqlCommand())
                {
                    comando.Connection = conexionDb;
                    comando.CommandText = "SELECT MAX(periodo_fin) FROM pago WHERE id_cliente = @id_cliente";
                    comando.Parameters.AddWithValue("@id_cliente", clienteId);

                    object result = comando.ExecuteScalar();
                    return result != DBNull.Value ? (DateTime?)result : null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el periodo_fin del cliente: " + ex.Message);
            }
            finally
            {
                CerrarConexion(conexionDb);
            }
        }
   
        public DateTime? ObtenerMaximoPeriodoFin(int clienteId)
        {
            MySqlConnection conexionDb = null;
            try
            {
                conexionDb = ObtenerConexion();

                using (var comando = new MySqlCommand())
                {
                    comando.Connection = conexionDb;

                    // Consulta para obtener la última fecha de periodo_fin registrada para un cliente
                    comando.CommandText = @"SELECT MAX(periodo_fin) AS max_periodo_fin
                                    FROM pago
                                    WHERE id_cliente = @id_cliente
                                    AND socio_al_pagar = 1";

                    comando.Parameters.AddWithValue("@id_cliente", clienteId);

                    object resultado = comando.ExecuteScalar();
                    if (resultado != DBNull.Value && resultado != null)
                    {
                        return Convert.ToDateTime(resultado);
                    }
                    return null;  // No hay registros previos
                }
            }
            finally
            {
                if (conexionDb != null)
                    conexionDb.Close();
            }
        }



    }
}

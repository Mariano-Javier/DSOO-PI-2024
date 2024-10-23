﻿using DSOO_PI_ComC_Grupo12.Config;
using DSOO_PI_ComC_Grupo12.Services;
using MySql.Data.MySqlClient;
using System;

namespace DSOO_PI_ComC_Grupo12.Repositories
{
    internal class PagoRepository
    {
        public void RegistrarPago(int idCliente, decimal monto, string medioPago, DateTime fechaPago)
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
                    comando.CommandText = "INSERT INTO pago (id_cliente, monto, medio_de_pago, fecha_pago) VALUES (@idCliente, @monto, @medioPago, @fechaPago)";

                    comando.Parameters.AddWithValue("@idCliente", idCliente);
                    comando.Parameters.AddWithValue("@monto", monto);
                    comando.Parameters.AddWithValue("@medioPago", medioPago);
                    comando.Parameters.AddWithValue("@fechaPago", fechaPago);

                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar el pago: " + ex.Message);
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

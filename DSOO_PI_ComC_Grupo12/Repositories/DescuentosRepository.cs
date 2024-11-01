using DSOO_PI_ComC_Grupo12.Config;
using DSOO_PI_ComC_Grupo12.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSOO_PI_ComC_Grupo12.Repositories
{
    internal class DescuentosRepository : BaseRepository
    {
        public void CargarDescuentos()
        {
            MySqlConnection conexionDb = null;
            try
            {
                conexionDb = ObtenerConexion();

                using (var comando = new MySqlCommand("SELECT tipo_pago, valor_descuento FROM descuentos", conexionDb))
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string tipoPago = reader.GetString("tipo_pago");
                        decimal valorDescuento = reader.GetDecimal("valor_descuento");

                        // Asigna los valores leídos a las propiedades correspondientes de ConfiguracionDescuentos
                        switch (tipoPago)
                        {
                            case "Tarjeta en 3 cuotas":
                                ConfiguracionDescuentos.Tarjeta3Cuotas = valorDescuento;
                                break;
                            case "Tarjeta en 6 cuotas":
                                ConfiguracionDescuentos.Tarjeta6Cuotas = valorDescuento;
                                break;
                            case "Efectivo":
                                ConfiguracionDescuentos.Efectivo = valorDescuento;
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar los descuentos: " + ex.Message);
            }
            finally
            {
                CerrarConexion(conexionDb);
            }
        }
        public List<(int Id, string Tipo, decimal Descuento)> ObtenerDescuentos()
        {
            List<(int Id, string Tipo, decimal Descuento)> descuentos = new List<(int Id, string Tipo, decimal Descuento)>();
            MySqlConnection conexionDb = null;
            try
            {
                conexionDb = ObtenerConexion();

                using (var comando = new MySqlCommand("SELECT id, tipo_pago, valor_descuento FROM descuentos", conexionDb))
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("id");
                        string tipoPago = reader.GetString("tipo_pago");
                        decimal valorDescuento = reader.GetDecimal("valor_descuento");

                        descuentos.Add((id, tipoPago, valorDescuento));
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los descuentos: " + ex.Message);
            }
            finally
            {
                CerrarConexion(conexionDb);
            }
            return descuentos;
        }
        public void ActualizarDescuento(int id, string tipoPago, decimal valorDescuento)
        {
            MySqlConnection conexionDb = null;
            try
            {
                conexionDb = ObtenerConexion();

                using (var comando = new MySqlCommand("UPDATE descuentos SET tipo_pago = @tipoPago, valor_descuento = @valorDescuento WHERE id = @id", conexionDb))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@tipoPago", tipoPago);
                    comando.Parameters.AddWithValue("@valorDescuento", valorDescuento);

                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el descuento: " + ex.Message);
            }
            finally
            {
                CerrarConexion(conexionDb);
            }
        }
    }
}

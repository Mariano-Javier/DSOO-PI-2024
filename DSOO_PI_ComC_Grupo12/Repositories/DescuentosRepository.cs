using DSOO_PI_ComC_Grupo12.Config;
using DSOO_PI_ComC_Grupo12.Helpers;
using DSOO_PI_ComC_Grupo12.Models;
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

                using (var comando = new MySqlCommand("SELECT id, tipo_pago, valor_descuento FROM descuentos", conexionDb))
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("id");
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
            catch (MySqlException ex)
            {
                // Manejo específico de errores de MySQL
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
                throw new Exception($"Error al cargar los descuentos: {ex.Message}");
            }
            finally
            {
                CerrarConexion(conexionDb);
            }
        }


        public List<Descuento> ObtenerDescuentos()
        {
            List<Descuento> descuentos = new List<Descuento>();
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

                        descuentos.Add(new Descuento
                        {
                            Id = id,
                            TipoPago = tipoPago,
                            ValorDescuento = valorDescuento
                        });
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

        public void ActualizarDescuento(Descuento descuento)
        {
            MySqlConnection conexionDb = null;
            try
            {
                conexionDb = ObtenerConexion();

                using (var comando = new MySqlCommand("UPDATE descuentos SET tipo_pago = @tipoPago, valor_descuento = @valorDescuento WHERE id = @id", conexionDb))
                {
                    comando.Parameters.AddWithValue("@id", descuento.Id);
                    comando.Parameters.AddWithValue("@tipoPago", descuento.TipoPago);
                    comando.Parameters.AddWithValue("@valorDescuento", descuento.ValorDescuento);

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

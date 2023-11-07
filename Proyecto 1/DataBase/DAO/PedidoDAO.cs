using Proyecto_1.Modelo;
using System.Configuration;
using System.Data.SqlClient;

namespace Proyecto_1.DAO
{
    public class PedidoDAO
    {
        private string ConexionDataBase;

        public PedidoDAO()
        {
            ConexionDataBase = ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString;
        }

        public void InsertarPedido(Pedido pedido)
        {
            using (SqlConnection conexion = new SqlConnection(ConexionDataBase))
            {
                conexion.Open();
                string consulta = "INSERT INTO Pedidos (NumeroPedido, PrecioTotalPedidos) VALUES (@NumeroPedido, @PrecioTotalPedidos)";
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@NumeroPedido", pedido.NumeroPedido);
                    comando.Parameters.AddWithValue("@PrecioTotalPedidos", pedido.PrecioTotalPedidos);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void ActualizarPedido(Pedido pedido)
        {
            using (SqlConnection conexion = new SqlConnection(ConexionDataBase))
            {
                conexion.Open();
                string consulta = "UPDATE Pedidos SET PrecioTotalPedidos = @PrecioTotalPedidos WHERE NumeroPedido = @NumeroPedido";
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@NumeroPedido", pedido.NumeroPedido);
                    comando.Parameters.AddWithValue("@PrecioTotalPedidos", pedido.PrecioTotalPedidos);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void EliminarPedido(int numeroPedido)
        {
            using (SqlConnection conexion = new SqlConnection(ConexionDataBase))
            {
                conexion.Open();
                string consulta = "DELETE FROM Pedidos WHERE NumeroPedido = @NumeroPedido";
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@NumeroPedido", numeroPedido);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public Pedido ObtenerPedidoPorNumero(int numeroPedido)
        {
            using (SqlConnection conexion = new SqlConnection(ConexionDataBase))
            {
                conexion.Open();
                string consulta = "SELECT NumeroPedido, PrecioTotalPedidos FROM Pedidos WHERE NumeroPedido = @NumeroPedido";
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@NumeroPedido", numeroPedido);
                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            Pedido pedido = new Pedido
                            {
                                NumeroPedido = lector.GetInt32(0),
                                PrecioTotalPedidos = lector.GetInt32(1)
                            };
                            return pedido;
                        }
                        else
                        {
                            return null; // El pedido no se encontro
                        }
                    }
                }
            }
        }
    }
}

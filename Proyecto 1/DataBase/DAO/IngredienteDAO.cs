using Proyecto_1.Modelo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.DAO
{
    public class IngredienteDAO
    {
        private string ConexionDataBase;
        
        public IngredienteDAO()
        {
            ConexionDataBase = ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString;
        }

        public void InsertarIngrediente(Ingrediente ingrediente)
        {
            using (SqlConnection conexion = new SqlConnection(ConexionDataBase))
            {
                conexion.Open();
                string consulta = "INSERT INTO Ingredientes (IdIngrediente, NombreIngrediente, Precio, TipoIngredienteId) " +
                                  "VALUES (@IdIngrediente, @NombreIngrediente, @Precio, @TipoIngredienteId)";
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@IdIngrediente", ingrediente.IdIngrediente);
                    comando.Parameters.AddWithValue("@NombreIngrediente", ingrediente.NombreIngrediente);
                    comando.Parameters.AddWithValue("@Precio", ingrediente.Precio);
                    comando.Parameters.AddWithValue("@TipoIngredienteId", ingrediente.tipoIngrediente.IdTipoIngrediente); // Asumiendo que tipoIngrediente es una propiedad en la clase Ingrediente.
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void ActualizarIngrediente(Ingrediente ingrediente)
        {
            using (SqlConnection conexion = new SqlConnection(ConexionDataBase))
            {
                conexion.Open();
                string consulta = "UPDATE Ingredientes " +
                                  "SET NombreIngrediente = @NombreIngrediente, Precio = @Precio, TipoIngredienteId = @TipoIngredienteId " +
                                  "WHERE IdIngrediente = @IdIngrediente";
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@IdIngrediente", ingrediente.IdIngrediente);
                    comando.Parameters.AddWithValue("@NombreIngrediente", ingrediente.NombreIngrediente);
                    comando.Parameters.AddWithValue("@Precio", ingrediente.Precio);
                    comando.Parameters.AddWithValue("@TipoIngredienteId", ingrediente.tipoIngrediente.IdTipoIngrediente);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void EliminarIngrediente(int idIngrediente)
        {
            using (SqlConnection conexion = new SqlConnection(ConexionDataBase))
            {
                conexion.Open();
                string consulta = "DELETE FROM Ingredientes WHERE IdIngrediente = @IdIngrediente";
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@IdIngrediente", idIngrediente);
                    comando.ExecuteNonQuery();
                }
            }
        }      
    }
}

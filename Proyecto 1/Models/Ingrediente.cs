using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.Modelo
{
    internal class Ingrediente
    {
        private int IdIngrediente { get; set; }
        private string NombreIngrediente { get; set; }
        private int Precio { get; set; }
        private TipoIngrediente tipoIngrediente { get; set; }

        public Ingrediente(int Id, string NombreIngrediente, int Precio, TipoIngrediente tipoIngrediente)
        {
            this.IdIngrediente = Id;
            this.Precio = Precio;
            this.NombreIngrediente = NombreIngrediente;
            this.tipoIngrediente = tipoIngrediente;
        }

        public override string ToString()
        {
            return $"Ingrediente #{IdIngrediente} - Nombre: {NombreIngrediente} - Precio: {Precio} - Tipo: {tipoIngrediente}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false; // El objeto no es de la misma clase
            }

            Ingrediente otroIngrediente = (Ingrediente)obj;

            // Comparamos los IdIngrediente para determinar si son iguales
            return this.IdIngrediente == otroIngrediente.IdIngrediente;
        }
    }
}

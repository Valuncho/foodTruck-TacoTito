using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.Modelo
{
    internal class Ingrediente
    {
        private int Id { get; set; }
        private string NombreIngrediente { get; set; }
        private int Precio { get; set; }
        private TipoIngrediente tipoIngrediente { get; set; }


        public Ingrediente(int Id, string NombreIngrediente, int Precio, TipoIngrediente tipoIngrediente) {
            this.Id = Id;
            this.Precio = Precio;
            this.NombreIngrediente = NombreIngrediente;
            this.tipoIngrediente = tipoIngrediente;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.DTO
{
    internal class IngredienteDTO
    {
        public int IdIngrediente { get; set; }
        public string NombreIngrediente { get; set; }
        public int Precio { get; set; }
        public TipoIngredienteDTO TipoIngrediente { get; set; }
    }
}

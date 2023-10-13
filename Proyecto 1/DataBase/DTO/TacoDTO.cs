using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.DTO
{
    internal class TacoDTO
    {
        public int NumeroTaco { get; set; }
        public List<IngredienteDTO> Ingrediente { get; set;}
        public int PrecioTotal { get; set; }
    }
}

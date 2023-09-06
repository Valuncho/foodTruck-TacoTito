using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.Modelo
{
    internal class TipoIngrediente
    {
        private int IdTipoIngrediente { get; set; }
        private string Detalle { get; set; }
        private int CantidadMax { get; set; }

        public TipoIngrediente(int IdTipoIngrediente, string Detalle, int CantidadMax)
        {
            this.IdTipoIngrediente = IdTipoIngrediente;
            this.Detalle = Detalle;
            this.CantidadMax = CantidadMax;
        }
    }
}

using Proyecto_1.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.DTO
{
    internal class PedidoDTO
    {
        public int NumeroPedido { get; set; }
        public List<Taco> ListaTacos { get; set; }
        public int PrecioToTalPedidos { get; set; }

    }
}

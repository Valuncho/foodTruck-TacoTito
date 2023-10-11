using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.Modelo
{
    internal class Pedido
    {
        private int NumeroPedido { get; set; }
        private List<Taco> ListaTacos { get; set; }
        private int PrecioTotalPedidos { get; set; }
        public Pedido(int NumeroPedido, List<Taco> ListaTacos, int PrecioTotalPedidos)
        {
            this.NumeroPedido = NumeroPedido;
            this.ListaTacos = ListaTacos;
            this.PrecioTotalPedidos = PrecioTotalPedidos;
        }

    }
}

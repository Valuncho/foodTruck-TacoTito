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

        public override string ToString()
        {
            return $"Pedido #{NumeroPedido} - Total: {PrecioTotalPedidos} - Tacos: {ListaTacos.Count}";
        }


        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false; // El objeto no es de la misma clase
            }

            Pedido otroPedido = (Pedido)obj;

            // Comparamos los numeros de pedido para determinar si son iguales
            return this.NumeroPedido == otroPedido.NumeroPedido;
        }
    }
}

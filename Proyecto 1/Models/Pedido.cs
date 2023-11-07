using System;
using System.Collections.Generic;


namespace Proyecto_1.Modelo
{
    public class Pedido
    {
        public int NumeroPedido { get; set; }
        public List<Taco> ListaTacos { get; set; }
        public int PrecioTotalPedidos { get; set; }

        public Pedido(int NumeroPedido, int PrecioTotalPedidos)
        {
            this.NumeroPedido = NumeroPedido;
            this.PrecioTotalPedidos = PrecioTotalPedidos;
        }
        public Pedido()
        {
            this.ListaTacos = new List<Taco>();
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

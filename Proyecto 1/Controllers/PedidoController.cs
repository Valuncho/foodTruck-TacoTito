using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_1.Modelo;

namespace Proyecto_1.PedidoController
{
    internal class PedidoController
    {
        private static PedidoController instance;
        PedidoController pedidoController;
        private List<Pedido> listaPedido;
        private int numeroPedido;


        public PedidoController()
        {
            pedidoController = new PedidoController();
            listaPedido = new List<Pedido>();
            numeroPedido = 0;
        }

        public static PedidoController getInstance() 
        { 
            return instance;
        }
        



    }
}

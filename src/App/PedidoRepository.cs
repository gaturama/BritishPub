using Models;
using Interface;

namespace PubApp
{
    public class PedidoRepository : IPedidoRepository
    {
        private List<Pedido> pedidos = new List<Pedido>();

        public void AdicionarPedido(Pedido pedido)
        {
            pedidos.Add(pedido);
        }
        public void ExcluirPedido(int pedidoId)
        {
            Pedido pedido = pedidos.Find(c => c.PedidoId == pedidoId);
            if (pedido != null)
            {
                pedidos.Remove(pedido);
            }
        }

        public List<Pedido> ObterPedidos()
        {
            return pedidos;
        }

    }
}

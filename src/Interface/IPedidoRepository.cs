using System.Collections.Generic;

namespace PubApp
{
    public interface IPedidoRepository
    {
        void AdicionarPedido(Pedido pedido);
        void ExcluirPedido(int pedidoId);
        List<Pedido> ObterPedidos();
    }
}

using System.Collections.Generic;
using Models;

namespace Interface
{
    public interface IPedidoRepository
    {
        void AdicionarPedido(Pedido pedido);
        void ExcluirPedido(int pedidoId);
        List<Pedido> ObterPedidos();
    }
}

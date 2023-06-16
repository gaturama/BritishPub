using System.Collections.Generic;

namespace PubApp
{
    public class PedidoService
    {
        private IPedidoRepository pedidoRepository;
        private IClienteRepository clienteRepository;

        public PedidoService(IPedidoRepository pedidoRepository, IClienteRepository clienteRepository)
        {
            this.pedidoRepository = pedidoRepository;
            this.clienteRepository = clienteRepository;
        }

        public void RealizarPedido(string item, int quantidade, decimal valorTotal, int clienteId)
        {
            Cliente cliente = clienteRepository.ObterClientes().Find(c => c.ClienteId == clienteId);
            if (cliente != null)
            {
                Pedido pedido = new Pedido
                {
                    Item = item,
                    Quantidade = quantidade,
                    ValorTotal = valorTotal,
                    Cliente = cliente
                };
                pedidoRepository.AdicionarPedido(pedido);
            }
        }

        public List<Pedido> ObterPedidos()
        {
            return pedidoRepository.ObterPedidos();
        }
    }
}

using Models;
using Interface;

namespace Controllers
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

        public void RealizarPedido(string item, int quantidade, decimal valor, int clienteId)
        {
            Cliente cliente = clienteRepository.ObterClientes().Find(c => c.ClienteId == clienteId);
            if (cliente != null)
            {
                Pedido pedido = new Pedido
                {
                    Item = item,
                    Quantidade = quantidade,
                    Valor = valor,
                    Cliente = cliente
                };
                pedidoRepository.AdicionarPedido(pedido);
            }
        }

        public void ExcluirPedido(int pedidoId)
        {
            pedidoRepository.ExcluirPedido(pedidoId);
        }
        
        public List<Pedido> ObterPedidos()
        {
            return pedidoRepository.ObterPedidos();
        }
    }
}

using Models;

namespace Controllers
{
    public class PedidoController
    {
        public List<Pedido> pedidos = new List<Pedido>();
        public int pedidoId = 1;

        public void AdicionarPedido(string item, int quantidade, decimal valor, Cliente cliente)
        {
            Pedido pedido = new Pedido
            {
                PedidoId = pedidoId,
                Item = item,
                Quantidade = quantidade,
                Valor = valor,
                Cliente = cliente
            };
            pedidos.Add(pedido);
            pedidoId++;
        }

        public void ExcluirPedido(int pedidoId)
        {
            Pedido pedido = pedidos.Find(c => c.PedidoId == pedidoId);
            if (pedido != null)
            {
                pedidos.Remove(pedido);
                Console.WriteLine("Cliente excluído com sucesso!");
            }
            else
            {
                Console.WriteLine("Cliente não encontrado");
            }
        }
        
        public List<Pedido> ObterPedidos()
        {
            return pedidos;
        }
    }
}
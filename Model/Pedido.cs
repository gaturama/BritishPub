using System;

namespace Model
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public string Descricao { get; set; }
        public string Cliente { get; set; }

        public static List<Pedido> Pedidos {get; set; } = new List<Pedido>();

        public Pedido(int pedidoId, string descricao, string cliente)
        {
            PedidoId = pedidoId;
            Descricao = descricao;
            Cliente = cliente;

            Pedidos.Add(this);
        }

        public override string ToString()
        {
            return $"Id: {PedidoId}, Descricao: {Descricao}, Cliente: {Cliente}";
        }

        public static void AlterarPedido(int pedidoId, string descricao, string Cliente)
        {
            Pedido pedido = BuscarPedido(pedidoId);
            pedido.Descricao = descricao;
            pedido.Cliente = cliente;
        }

        public static void ExcluirPedido(int pedidoId)
        {
            Pedido pedido = BuscarPedido(pedidoId);
            Pedidos.Remove(pedido);
        }

        public static Pedido BuscarPedido(int pedidoId)
        {
            Pedido? pedido = Pedidos.Find(c => c.PedidoId == pedidoId);
            if(pedido == null)
            {
                throw new Exception("Pedido não encontrado");
            }

            return pedido;
        }
    }
}
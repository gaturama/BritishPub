using System;
using System.Collections.Generic;

namespace Model
{
    public interface IPedidoRepository
    {
        Pedido BuscarPedido(int pedidoId);
        void ExcluirPedido(int pedidoId);
        void SalvarPedido(Pedido pedido);
        IEnumerable<Pedido> ListarPedidos();
    }

    public class Pedido
    {
        public int PedidoId { get; private set; }
        public string Descricao { get; private set; }
        public string Cliente { get; private set; }

        public Pedido(int pedidoId, string descricao, string cliente)
        {
            PedidoId = pedidoId;
            Descricao = descricao;
            Cliente = cliente;
        }

        public void AlterarPedido(string descricao, string cliente)
        {
            Descricao = descricao;
            Cliente = cliente;
        }

        public override string ToString()
        {
            return $"Id: {PedidoId}, Descricao: {Descricao}, Cliente: {Cliente}";
        }
    }

    public class PedidoRepository : IPedidoRepository
    {
        private List<Pedido> pedidos = new List<Pedido>();

        public Pedido BuscarPedido(int pedidoId)
        {
            Pedido pedido = pedidos.Find(p => p.PedidoId == pedidoId);
            if (pedido == null)
            {
                throw new Exception("Pedido não encontrado");
            }

            return pedido;
        }

        public void ExcluirPedido(int pedidoId)
        {
            Pedido pedido = BuscarPedido(pedidoId);
            pedidos.Remove(pedido);
        }

        public void SalvarPedido(Pedido pedido)
        {
            Pedido pedidoExistente = pedidos.Find(p => p.PedidoId == pedido.PedidoId);
            if (pedidoExistente != null)
            {
                throw new Exception("O pedido já existe no repositório");
            }

            pedidos.Add(pedido);
        }

        public IEnumerable<Pedido> ListarPedidos()
        {
            return pedidos;
        }
    }
}

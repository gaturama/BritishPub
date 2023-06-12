using System;
using System.Collections.Generic;

namespace Model
{
    public interface IPedidoRepository
    {
        void ExcluirPedido(int pedidoId);
        void SalvarPedido(Pedido pedido);
        Pedido BuscarPedido(int pedidoId);
        List<Pedido> ListarPedidos();
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
        private List<Pedido> Pedidos { get; set; } = new List<Pedido>();

        public Pedido BuscarPedido(int pedidoId)
        {
            var pedido = Pedidos.Find(p => p.PedidoId == pedidoId);
            if (pedido == null)
            {
                throw new Exception("pedido não encontrado");
            }

            return pedido;
        }

        public void ExcluirPedido(int pedidoId)
        {
            var pedido = Pedidos.Find(p => p.PedidoId == pedidoId);
            if(pedido == null)
            {
                throw new Exception("Pedido não encontrado");
            }
            Pedidos.Remove(pedido);
        }

        public void SalvarPedido(Pedido pedido)
        {
            Pedido pedido = pedidos.Find(p => p.PedidoId == pedido.PedidoId);
            if (pedido == null)
            {
                throw new Exception("Pedido não encontrado");
            }

            var pedidoExistente = Pedidos.Find(p => p.PedidoId == pedido.PedidoId);
            if(pedidoExistente != null)
            {
                Pedido.Remove(pedidoExistente);
            }

            Pedidos.Add(pedido);
        }

        public List<Pedido> ListarPedidos()
        {
            return pedidos;
        }
    }
}

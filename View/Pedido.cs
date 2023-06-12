namespace View
{
    public interface IPedidoInputPort
    {
        void CadastrarPedido();
        void AlterarPedido();
        void ExcluirPedido();
        void ListarPedidos();
    }

    public interface IPedidoOutputPort
    {
        void PedidoCadastradoComSucesso();
        void ErroAoCadastrarPedido(string mensagemErro);
        void PedidoAlteradoComSucesso();
        void ErroAoAlterarPedido(string mensagemErro);
        void PedidoExcluidoComSucesso();
        void ErroAoExcluirPedido(string mensagemErro);
        void ListarPedidos(IEnumerable<Model.Pedido> pedidos);
    }

    public class PedidoView : IPedidoOutputPort
    {
        private readonly IPedidoInputPort _pedidoInputPort;

        public PedidoView(IPedidoInputPort pedidoInputPort)
        {
            _pedidoInputPort = pedidoInputPort;
        }

        public void CadastrarPedido()
        {
            Console.WriteLine("Digite o Id do pedido:");
            string pedidoId = Console.ReadLine();
            Console.WriteLine("Digite a descrição do pedido:");
            string descricao = Console.ReadLine();
            Console.WriteLine("Digite o nome do cliente:");
            string cliente = Console.ReadLine();

            _pedidoInputPort.CadastrarPedido(pedidoId, descricao, cliente);
        }

        public void AlterarPedido()
        {
            Console.WriteLine("Digite o Id do pedido:");
            string pedidoId = Console.ReadLine();
            Console.WriteLine("Digite a descrição do pedido:");
            string descricao = Console.ReadLine();
            Console.WriteLine("Digite o nome do cliente:");
            string cliente = Console.ReadLine();

            _pedidoInputPort.AlterarPedido(pedidoId, descricao, cliente);
        }

        public void ExcluirPedido()
        {
            Console.WriteLine("Digite o Id do pedido:");
            string pedidoId = Console.ReadLine();

            _pedidoInputPort.ExcluirPedido(pedidoId);
        }

        public void ListarPedidos()
        {
            _pedidoInputPort.ListarPedidos();
        }

        public void PedidoCadastradoComSucesso()
        {
            Console.WriteLine("Pedido cadastrado com sucesso");
        }

        public void ErroAoCadastrarPedido(string mensagemErro)
        {
            Console.WriteLine($"Erro ao cadastrar o pedido: {mensagemErro}");
        }

        public void PedidoAlteradoComSucesso()
        {
            Console.WriteLine("Pedido alterado com sucesso");
        }

        public void ErroAoAlterarPedido(string mensagemErro)
        {
            Console.WriteLine($"Erro ao alterar o pedido: {mensagemErro}");
        }

        public void PedidoExcluidoComSucesso()
        {
            Console.WriteLine("Pedido excluído com sucesso");
        }

        public void ErroAoExcluirPedido(string mensagemErro)
        {
            Console.WriteLine($"Erro ao excluir o pedido: {mensagemErro}");
        }

        public void ListarPedidos(IEnumerable<Model.Pedido> pedidos)
        {
            Console.WriteLine("Listar Pedidos");
            foreach (Model.Pedido pedido in pedidos)
            {
                Console.WriteLine(pedido);
            }
        }
    }
}

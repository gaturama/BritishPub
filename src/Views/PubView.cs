using Controllers;

namespace Views
{
    public class PubView
    {
        private ClienteService clienteService;
        private PedidoService pedidoService;

        public PubView(ClienteService clienteService, PedidoService pedidoService)
        {
            this.clienteService = clienteService;
            this.pedidoService = pedidoService;
        }

        public void ExibirMenu()
        {
            Console.WriteLine("===========================");
            Console.WriteLine("Bem-vindo ao PubApp!\n");
            Console.WriteLine("1 - Cadastrar cliente");
            Console.WriteLine("2 - Excluir cliente");
            Console.WriteLine("3 - Realizar pedido");
            Console.WriteLine("4 - Excluir pedido");
            Console.WriteLine("5 - Exibir clientes");
            Console.WriteLine("6 - Exibir pedidos");
            Console.WriteLine("0. Sair");
            Console.WriteLine("===========================");
            Console.WriteLine("Opção:");
        }

        public void CadastrarCliente()
        {
            Console.WriteLine("\nCadastro de Cliente");
            Console.WriteLine("\nDigite o nome do cliente:");
            string Nome = Console.ReadLine();
            Console.WriteLine("\nDigite o telefone do cliente:");
            string Telefone = Console.ReadLine();
            clienteService.CadastrarCliente(Nome, Telefone);
            Console.WriteLine("\nCliente cadastrado com sucesso!");
        }

        public void ExcluirCliente()
        {
            Console.WriteLine("Exclusão de Cliente");
            Console.WriteLine("\nDigite o ID do cliente:");
            int clienteId = int.Parse(Console.ReadLine());
            clienteService.ExcluirCliente(clienteId);
            Console.WriteLine("\nCliente excluído com sucesso!");
        }

        public void RealizarPedido()
        {
            Console.WriteLine("Realização de Pedido");
            Console.WriteLine("\nDigite o item:");
            string item = Console.ReadLine();
            Console.WriteLine("\nDigite a quantidade:");
            int quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o valor total:");
            decimal valor = decimal.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o ID do cliente:");
            int clienteId = int.Parse(Console.ReadLine());
            pedidoService.RealizarPedido(item, quantidade, valor, clienteId);
            Console.WriteLine("\nPedido realizado com sucesso!");
        }

        public void ExcluirPedido()
        {
            Console.WriteLine("Exclusão de Pedido");
            Console.WriteLine("\nDigite o ID do pedido:");
            int pedidoId = int.Parse(Console.ReadLine());
            clienteService.ExcluirCliente(pedidoId);
            Console.WriteLine("\nPedido excluído com sucesso!");
        }

        public void ExibirClientes()
        {
            Console.WriteLine("Lista de Clientes");
            var clientes = clienteService.ObterClientes();
            foreach (var cliente in clientes)
            {
                Console.WriteLine($"\nID: {cliente.ClienteId}, \nNome: {cliente.Nome}, \nTelefone: {cliente.Telefone}");
            }
        }

        public void ExibirPedidos()
        {
            Console.WriteLine("Lista de Pedidos");
            var pedidos = pedidoService.ObterPedidos();
            foreach (var pedido in pedidos)
            {
                Console.WriteLine($"\nID: {pedido.PedidoId}, \nItem: {pedido.Item}, \nQuantidade: {pedido.Quantidade}, \nValor Total: {pedido.Valor}, \nCliente: {pedido.Cliente.Nome}");
            }
        }
    }
}

using System;

namespace PubApp
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
            Console.WriteLine("Bem-vindo ao PubApp!");
            Console.WriteLine("1. Cadastrar cliente");
            Console.WriteLine("2. Excluir cliente");
            Console.WriteLine("3. Realizar pedido");
            Console.WriteLine("4. Exibir clientes");
            Console.WriteLine("5. Exibir pedidos");
            Console.WriteLine("0. Sair");
            Console.WriteLine("Digite o número da opção desejada:");
        }

        public void CadastrarCliente()
        {
            Console.WriteLine("Cadastro de Cliente");
            Console.WriteLine("Digite o nome do cliente:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a idade do cliente:");
            int telefone = int.Parse(Console.ReadLine());
            clienteService.CadastrarCliente(nome, telefone);
            Console.WriteLine("Cliente cadastrado com sucesso!");
        }

        public void ExcluirCliente()
        {
            Console.WriteLine("Exclusão de Cliente");
            Console.WriteLine("Digite o ID do cliente a ser excluído:");
            int clienteId = int.Parse(Console.ReadLine());
            clienteService.ExcluirCliente(clienteId);
            Console.WriteLine("Cliente excluído com sucesso!");
        }

        public void RealizarPedido()
        {
            Console.WriteLine("Realização de Pedido");
            Console.WriteLine("Digite o item:");
            string item = Console.ReadLine();
            Console.WriteLine("Digite a quantidade:");
            int quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor total:");
            decimal valorTotal = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ID do cliente:");
            int clienteId = int.Parse(Console.ReadLine());
            pedidoService.RealizarPedido(item, quantidade, valorTotal, clienteId);
            Console.WriteLine("Pedido realizado com sucesso!");
        }

        public void ExcluirPedido()
        {
            Console.WriteLine("Exclusão de Pedido");
            Console.WriteLine("Digite o ID do pedido a ser excluído:");
            int pedidoId = int.Parse(Console.ReadLine());
            clienteService.ExcluirCliente(pedidoId);
            Console.WriteLine("Pedido excluído com sucesso!");
        }

        public void ExibirClientes()
        {
            Console.WriteLine("Lista de Clientes");
            var clientes = clienteService.ObterClientes();
            foreach (var cliente in clientes)
            {
                Console.WriteLine($"ID: {cliente.ClienteId}, Nome: {cliente.Nome}, Telefone: {cliente.Telefone}");
            }
        }

        public void ExibirPedidos()
        {
            Console.WriteLine("Lista de Pedidos");
            var pedidos = pedidoService.ObterPedidos();
            foreach (var pedido in pedidos)
            {
                Console.WriteLine($"ID: {pedido.PedidoId}, Item: {pedido.Item}, Quantidade: {pedido.Quantidade}, Valor Total: {pedido.ValorTotal}, Cliente: {pedido.Cliente.Nome}");
            }
        }
    }
}

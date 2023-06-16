using Models;
using Controllers;

namespace View
{
    public class PubView
    {
        private ClienteController clienteController;
        private PedidoController pedidoController;

        public PubView()
        {
            clienteController = new ClienteController();
            pedidoController = new PedidoController();

        }

        public void Menu()
        {
            Console.WriteLine("==========================");
            Console.WriteLine("Bem-vindo ao British Pub!\n");
            Console.WriteLine("1 - Cadastrar Cliente");
            Console.WriteLine("2 - Realizar Pedido");
            Console.WriteLine("3 - Exibir Clientes");
            Console.WriteLine("4 - Exibir Pedidos");
            Console.WriteLine("5 - Excluir Clientes");
            Console.WriteLine("6 - Excluir Pedidos");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("==========================");
            Console.WriteLine("Opção:");
        }

        public void CadastrarCliente()
        {
            Console.WriteLine("Cadastro de Cliente");
            Console.WriteLine("\nDigite o nome do Cliente:"); 
            string nome = Console.ReadLine();
            Console.WriteLine("\nDigite o telefone do Cliente:");
            int telefone = int.Parse(Console.ReadLine());
            clienteController.CadastrarCliente(nome, telefone);
            Console.WriteLine("\nCliente cadastrado com sucesso");
        }   

        public void RealizarPedido()
        {
            Console.WriteLine("Realização de Pedido");
            Console.WriteLine("Digite o item:");
            string item = Console.ReadLine();
            Console.WriteLine("\nDigite a quantidade:");
            int quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o valor total:");
            decimal valorTotal = decimal.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o ID do cliente:");
            int clienteId = int.Parse(Console.ReadLine());
            Cliente cliente = clienteController.ObterClientes().Find(c => c.ClienteId == clienteId);
            if (cliente != null)
            {
                pedidoController.AdicionarPedido(item, quantidade, valorTotal, cliente);
                Console.WriteLine("\nPedido realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("\nCliente não encontrado!");
            }
        }

        public void ExibirClientes()
        {
            Console.WriteLine("Lista de Clientes");
            List<Cliente> clientes = clienteController.ObterClientes();
            foreach (Cliente cliente in clientes)
            {
                Console.WriteLine($"ID: {cliente.ClienteId}, Nome: {cliente.Nome}, Telefone: {cliente.Telefone}");
            }
        }

        public void ExibirPedidos()
        {
            Console.WriteLine("Lista de Pedidos");
            List<Pedido> pedidos = pedidoController.ObterPedidos();
            foreach (Pedido pedido in pedidos)
            {
                Console.WriteLine($"ID: {pedido.PedidoId}, Item: {pedido.Item}, Quantidade: {pedido.Quantidade}, Valor Total: {pedido.Valor}, Cliente: {pedido.Cliente.Nome}");
            }
        }

         public void ExcluirCliente()
        {
            Console.WriteLine("Exclusão de Cliente");
            Console.WriteLine("\nDigite o ID do cliente a ser excluído:");
            int clienteId = int.Parse(Console.ReadLine());
            clienteController.ExcluirCliente(clienteId);
        }

        public void ExcluirPedido()
        {
            Console.WriteLine("Exclusão de Pedido");
            Console.WriteLine("\nDigite o ID do pedido a ser excluído:");
            int pedidoId = int.Parse(Console.ReadLine());
            pedidoController.ExcluirPedido(pedidoId);
        }
    }
}

using Views;
using Controllers;
using Interface;

namespace PubApp
{
    class Program
    {
        static void Main(string[] args)
        {

            IClienteRepository clienteRepository = new ClienteRepository();
            IPedidoRepository pedidoRepository = new PedidoRepository();

            ClienteService clienteService = new ClienteService(clienteRepository);
            PedidoService pedidoService = new PedidoService(pedidoRepository, clienteRepository);

            PubView pubView = new PubView(clienteService, pedidoService);
            int opcao = -1;
            while (opcao != 0)
            {
                pubView.ExibirMenu();
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        pubView.CadastrarCliente();
                        break;
                    case 2:
                        pubView.ExcluirCliente();
                        break;
                    case 3:
                        pubView.RealizarPedido();
                        break;
                    case 4:
                        pubView.ExcluirPedido();
                        break;
                    case 5:
                        pubView.ExibirClientes();
                        break;
                    case 6:
                        pubView.ExibirPedidos();
                        break;
                    case 0:
                        Console.WriteLine("Até mais!");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
            Console.WriteLine();
        }
    }
}
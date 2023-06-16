using View;

namespace Pub{

class Program
    {
        static void Main(string[] args)
        {
            PubView pubView = new PubView();
            int opcao = -1;
            while (opcao != 0)
            {
                pubView.Menu();
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        pubView.CadastrarCliente();
                        break;
                    case 2:
                        pubView.RealizarPedido();
                        break;
                    case 3:
                        pubView.ExibirClientes();
                        break;
                    case 4:
                        pubView.ExibirPedidos();
                        break;
                    case 0:
                        Console.WriteLine("Obrigado por utilizar o British Pub! Até logo.");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Por favor, tente novamente.");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
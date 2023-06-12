namespace Program
{
    public class Pub
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("British Pub");
            int op = 0;

            do
            {
                Console.WriteLine("=========================");
                Console.WriteLine("1 - Cadastrar Pedido");
                Console.WriteLine("2 - Alterar Pedido");
                Console.WriteLine("3 - Excluir Pedido");
                Console.WriteLine("4 - Listar Pedidos");
                Console.WriteLine("5 - Cadastrar Produto");
                Console.WriteLine("6 - Alterar Produto");
                Console.WriteLine("7 - Excluir Produto");
                Console.WriteLine("8 - Listar Produtos");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("=========================");

                switch(op)
                {
                    case 0:
                        Console.WriteLine("Até mais :)");
                        break;
                    case 1:
                        View.Pedido.CadastrarPedido();
                        break; 
                    case 2:
                        View.Pedido.AlterarPedido();
                        break;
                    case 3:
                        View.Pedido.ExcluirPedido();
                        break;
                    case 4:
                        View.Pedido.ListarPedidos();
                        break;
                    case 5:
                        View.Produto.CadastrarProduto();
                        break;
                    case 6: 
                        View.Produto.AlterarProduto();
                        break;
                    case 7:
                        View.Produto.ExcluirProduto();
                        break;
                    case 8:
                        View.Produto.ListarProdutos();
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;                                  
                }
            }while(op != 0);
        }
    }
}
namespace View
{
    public class Pedido
    {
        public static void CadastrarPedido()
        {
            Console.WriteLine("Digite o Id do pedido:");
            string PedidoId = Console.ReadLine();
            Console.WriteLine("Digite a descrição do pedido:");
            string Descricao = Console.ReadLine();
            Console.WriteLine("Digite o nome do cliente:");
            string Cliente = Console.ReadLine();
            try{
                Controller.Pedido.CadastrarPedido(PedidoId, Descricao, Cliente);
                Console.WriteLine("Pedido cadastrado com sucesso");
            }catch(Exception e)
            {
                Console.WriteLine($"Erro ao cadastrar o pedido: {e.Message}");
            }
        }

        public static void AlterarPedido()
        {
            Console.WriteLine("Digite o Id do pedido:");
            string PedidoId = Console.ReadLine();
            Console.WriteLine("Digite a descrição do pedido:");
            string Descricao = Console.ReadLine();
            Console.WriteLine("Digite o nome do cliente:");
            string Cliente = Console.ReadLine();
            try{
                Controller.Pedido.AlterarPedido(PedidoId, Descricao, Cliente);
                Console.WriteLine("Pedido alterado com sucesso");
            }catch(Exception e)
            {
                Console.WriteLine($"Erro ao alterar o pedido: {e.Message}");
            }
        }

        public static void ExcluirPedido()
        {
             Console.WriteLine("Digite o Id do pedido:");
            string PedidoId = Console.ReadLine();
            try{
                Controller.Pedido.ExcluirPedido(PedidoId);
                Console.WriteLine("Pedido excluído com sucesso");
            }catch(Exception e)
            {
                Console.WriteLine($"Erro ao excluir o pedido: {e.Message}");
            }
        }

        public static void ListarPedidos()
        {
            Console.WriteLine("Listar Pedidos");
            foreach(Model.Pedido pedido in Controller.Pedido.ListarPedidos())
            {
                Console.WriteLine(pedido);
            }
        }
    }
}
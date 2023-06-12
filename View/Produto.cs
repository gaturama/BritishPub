namespace View
{
    public class Produto
    {
        public static void CadastrarProduto()
        {
            Console.WriteLine("Digite o Id do produto:");
            string ProdutoId = Console.ReadLine();
            Console.WriteLine("Digite a descrição do produto:");
            string Descricao = Console.ReadLine();
            try{
                Controller.produto.CadastrarProduto(ProdutoId, Descricao);
                Console.WriteLine("Produto cadastrado com sucesso");
            }catch(Exception e)
            {
                Console.WriteLine($"Erro ao cadastrar o produto: {e.Message}");
            }
        }

        public static void AlterarProduto()
        {
            Console.WriteLine("Digite o Id do produto:");
            string ProdutoId = Console.ReadLine();
            Console.WriteLine("Digite a descrição do produto:");
            string Descricao = Console.ReadLine();
            try{
                Controller.produto.AlterarProduto(ProdutoId, Descricao);
                Console.WriteLine("Produto alterado com sucesso");
            }catch(Exception e)
            {
                Console.WriteLine($"Erro ao alterar o produto: {e.Message}");
            }
        }

        public static void ExcluirProduto()
        {
            Console.WriteLine("Digite o Id do produto:");
            string ProdutoId = Console.ReadLine();
            try{
                Controller.produto.ExcluirProduto(ProdutoId);
                Console.WriteLine("Produto excluído com sucesso");
            }catch(Exception e)
            {
                Console.WriteLine($"Erro ao excluir o produto: {e.Message}");
            }
        }

        public static void ListarProdutos()
        {
            Console.WriteLine("Listar Produtos");
            foreach(Model.Produto produto in Controller.Produto.ListarProdutos())
            {
                Console.WriteLine(produto);
            }
        }
    }
}
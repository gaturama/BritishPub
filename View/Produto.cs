namespace View
{
    public interface IProdutoInputPort
    {
        void CadastrarProduto();
        void AlterarProduto();
        void ExcluirProduto();
        void ListarProdutos();
    }

    public interface  IProdutoOutPutPort
    {
        void ProdutoCadastradoComSucesso();
        void ErroAoCadastrarProduto(string mensagemErro);
        void ProdutoAlteradoComSucesso();
        void ErroAoAlterarProduto(string mensagemErro);
        void ProdutoExcluidoComSucesso();
        void ErroAoExcluirProduto(string mensagemErro);
        void ListarProdutos(List<Model.Produto> produtos);
    }

    public class ProdutoView : IProdutoOutPutPort
    {
        private readonly IProdutoInputPort _produtoInputPort;

        public ProdutoView(IProdutoInputPort produtoInputPort)
        {
            _produtoInputPort = produtoInputPort;
        }
    
        public static void CadastrarProduto()
        {
            Console.WriteLine("Digite o Id do produto:");
            string ProdutoId = Console.ReadLine();
            Console.WriteLine("Digite a descrição do produto:");
            string Descricao = Console.ReadLine();
           
            _ProdutoInputPort.CadastrarProduto(ProdutoId, Descricao);
        }

        public static void AlterarProduto()
        {
            Console.WriteLine("Digite o Id do produto:");
            string ProdutoId = Console.ReadLine();
            Console.WriteLine("Digite a descrição do produto:");
            string Descricao = Console.ReadLine();
            
            _produtoInputPort.AlterarProduto(ProdutoID, Descricao);
        }

        public static void ExcluirProduto()
        {
            Console.WriteLine("Digite o Id do produto:");
            string ProdutoId = Console.ReadLine();
            
            _produtoInputPort.ExcluirProduto(ProdutoId);
        }

        public void ProdutoCadastradoComSucesso()
        {
            Console.WriteLine("Produto cadastrado com sucesso");
        }

        public void ErroAoCadastrarProduto(string mensagemErro)
        {
            Console.WriteLine($"Erro ao cadastrar o Produto: {mensagemErro}");
        }

        public void ProdutoAlteradoComSucesso()
        {
            Console.WriteLine("Produto alterado com sucesso");
        }

        public void ErroAoAlterarProduto(string mensagemErro)
        {
            Console.WriteLine($"Erro ao alterar o Produto: {mensagemErro}");
        }

        public void ProdutoExcluidoComSucesso()
        {
            Console.WriteLine("Produto excluído com sucesso");
        }

        public void ErroAoExcluirProduto(string mensagemErro)
        {
            Console.WriteLine($"Erro ao excluir o Produto: {mensagemErro}");
        }

        public static void ListarProdutos(List<Model.Produto> produtos)
        {
            Console.WriteLine("Listar Produtos");
            foreach(Model.Produto produto in produtos)
            {
                Console.WriteLine(produto);
            }
        }
    }
}
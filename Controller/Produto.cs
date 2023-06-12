namespace Controller
{
    public interface IProdutoInputPort
    {
        void CadastrarProduto(string produtoId, string nome);
        void AlterarProduto(string produtoId, string nome);
        void ExcluirProduto(string produtoId);
        Model.Produto BuscarProduto(string produtoId);
        List<Model.Produto> ListarProdutos();
    }

    public class ProdutoController : IProdutoInputPort
    {
        private readonly Model.IProdutoRepository _produtoRepository;
        private readonly IProdutoOutputPort _produtoOutputPort;

        public ProdutoController(Model.IProdutoRepository produtoRepository, IProdutoOutputPort produtoOutputPort)
        {
            _produtoRepository = produtoRepository;
            _produtoOutputPort = produtoOutputPort;
        }

        public void CadastrarProduto(string produtoId, string nome)
        {
            try
            {
                int idConvert = int.Parse(produtoId);
                Model.Produto produto = new Model.Produto(idConvert, nome);
                _produtoRepository.SalvarProduto(produto);
                _produtoOutputPort.ProdutoCadastradoComSucesso();
            }
            catch (Exception e)
            {
                _produtoOutputPort.ErroAoCadastrarProduto(e.Message);
            }
        }

        public void AlterarProduto(string produtoId, string nome)
        {
            try
            {
                int idConvert = int.Parse(produtoId);
                Model.Produto produto = _produtoRepository.BuscarProduto(idConvert);
                if (produto == null)
                {
                    throw new Exception("Produto não encontrado");
                }

                produto.AlterarProduto(produtoId, nome);
                _produtoRepository.SalvarProduto(produto);
                _produtoOutputPort.ProdutoAlteradoComSucesso();
            }
            catch (Exception e)
            {
                _produtoOutputPort.ErroAoAlterarProduto(e.Message);
            }
        }

        public void ExcluirProduto(string produtoId)
        {
            try
            {
                int idConvert = int.Parse(produtoId);
                Model.Produto produto = _produtoRepository.BuscarProduto(idConvert);
                if (produto == null)
                {
                    throw new Exception("Produto não encontrado");
                }

                _produtoRepository.ExcluirProduto(idConvert);
                _produtoOutputPort.ProdutoExcluidoComSucesso();
            }
            catch (Exception e)
            {
                _produtoOutputPort.ErroAoExcluirProduto(e.Message);
            }
        }

        public Model.Produto BuscarProduto(string produtoId)
        {
            try
            {
                int idConvert = int.Parse(produtoId);
                return _produtoRepository.BuscarProduto(idConvert);
            }
            catch (Exception e)
            {
                throw new Exception("Id inválido: " + e.Message);
            }
        }

        public List<Model.Produto> ListarProdutos()
        {
            return _produtoRepository.ListarProdutos();
        }
    }
}
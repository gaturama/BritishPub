namespace Controller
{
    public class Produto
    {
        public static void CadastrarProduto(string ProdutoId, string Nome)
        {
            int idConvert = 0;
            try{
                idConvert = int.Parse(ProdutoId);
            }catch(Exception){
                throw new Exception("Id inválido");
            }
            Model.Produto produto = new Model.Produto(idConvert, Nome);
        }

        public static void AlterarProduto(string ProdutoId, string Nome)
        {
            int idConvert = 0;
            try{
                idConvert = int.Parse(ProdutoId);
            }catch(Exception){
                throw new Exception("Id inválido");
            }
            Model.Produto.AlterarProduto(idConvert, Nome);
        }

        public static void ExcluirProduto(string ProdutoId)
        {
            int idConvert = 0;
            try{
                idConvert = int.Parse(ProdutoId);
            }catch(Exception){
                throw new Exception("Id inválido");
            }
            Model.Produto.ExcluirProduto(idConvert);
        }

        public static Model.Produto BuscarProduto(string ProdutoId)
        {
            int idConvert = 0;
            try{
                idConvert = int.Parse(ProdutoId);
            }catch(Exception){
                throw new Exception("Id inválido");
            }
            return Model.Produto.BuscarProduto(idConvert);
        }

        public static List<Model.Produto> ListarProdutos()
        {
            return Model.Produto.Produtos;
        }
    }
}
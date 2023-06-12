using System;

namespace Model
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }

        public static List<Produto> Produtos {get; set; } = new List<Produto>();

        public Produto(int produtoId, string nome)
        {
            ProdutoId = produtoId;
            Nome = nome;

            Produto.Add(this);
        }

        public override string ToString()
        {
            return $"Id: {ProdutoId}, Nome: {Nome}";
        }

        public static void AlterarProduto(int produtoId, string nome)
        {
            Produto produto = BuscarProduto(produtoId);
            produto.Nome = nome;
        }

        public static void ExcluirProduto(int produtoId)
        {
            Produto produto = BuscarProduto(produtoId);
            Produtos.Remove(produto);
        }

        public static Produto BuscarProduto(int produtoId)
        {
            Produto? produto = Produtos.Find(c => c.ProdutoId == produtoId);
            if(produto == null)
            {
                throw new Exception("Produto não encontrado");
            }

            return produto;
        }
    }
}
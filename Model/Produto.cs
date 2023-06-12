using System;
using System.Collections.Generic;

namespace Model
{
    public interface IProdutoRepository
    {
        void SalvarProduto(Produto produto);
        void ExcluirProduto(int produtoId);
        Produto BuscarProduto(int produtoId);
        List<Produto> ListarProdutos();
    }

    public class Produto
    {
        public int ProdutoId { get; private set; }
        public string Nome { get; private set; }

        public Produto(int produtoId, string nome)
        {
            ProdutoId = produtoId;
            Nome = nome;
        }

        public void AlterarProduto(int ProdutoId, string nome)
        {
            ProdutoId = produtoId;
            Nome = nome;
        }

        public override string ToString()
        {
            return $"Id: {ProdutoId}, Nome: {Nome}";
        }
    }

    public class ProdutoRepository : IProdutoRepository
    {
        private List<Produto> Produtos { get; set; } = new List<Produto>();

        public Produto BuscarProduto(int produtoId)
        {
            var produto = Pedidos.Find(p => p.ProdutoId == produtoId);
            if (produto == null)
            {
                throw new Exception("Produto não encontrado");
            }

            return produto;
        }

        public void ExcluirProduto(int produtoId)
        {
            var produto = Produtos.Find(p => p.ProdutoId == produtoId);
            if (produto == null)
            {
                throw new Exception("Produto não encontrado");
            }

            Produtos.Remove(produto);
        }

       public void SalvarProduto(Produto produto)
        {
            Produto produto = pedidos.Find(p => p.ProdutoId == produto.ProdutoId)
            if (produto == null)
            {
                throw new ArgumentNullException(nameof(produto));
            }

            var produtoExistente = Produtos.Find(p => p.ProdutoId == produto.ProdutoId);
            if (produtoExistente != null)
            {
                Produtos.Remove(produtoExistente);
            }

            Produtos.Add(produto);
        }


        public List<Produto> ListarProdutos()
        {
            return Produtos;
        }
    }
}
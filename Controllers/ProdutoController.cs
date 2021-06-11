using System.Collections.Generic;
using MVC1106.Models;
using MVC1106.Views;

namespace MVC1106.Controllers
{
    public class ProdutoController
    {
        Produto produto = new Produto();

        ProdutoView produtoview = new ProdutoView();

        public void ListarProdutos()
        {
            List<Produto> produtos = produto.Ler();           
            produtoview.Listar(produtos);

            // produtoview.Listar(produto.Ler());

        }

        public void Cadastrar()
        {
            Produto produto = produtoview.CadastrarProduto();

            produto.Inserir(produto);
        }
    }
}
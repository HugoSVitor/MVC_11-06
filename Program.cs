using System;
using MVC1106.Controllers;

namespace MVC1106
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController prod = new ProdutoController();

            prod.Cadastrar();
            prod.ListarProdutos();
        }
    }
}

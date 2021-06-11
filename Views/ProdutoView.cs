using System;
using System.Collections.Generic;
using MVC1106.Models;

namespace MVC1106.Views
{
    public class ProdutoView
    {
        public void Listar(List<Produto> produto)
        {
            foreach (var item in produto)
            {
                Console.WriteLine($"\nCódigo : {item.Codigo}");
                Console.WriteLine($"Nome : {item.Nome}");
                Console.WriteLine($"Preco : {item.Preco:C2}");
                
            }
        }

        public Produto CadastrarProduto()
        {
            Produto produto = new Produto();

            Console.WriteLine($"Digite um código");
            produto.Codigo = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Digite um nome");
            produto.Nome = Console.ReadLine();
            
            Console.WriteLine($"Digite um preço");
            produto.Preco = float.Parse(Console.ReadLine());
            
            return produto;
        }
    }
}
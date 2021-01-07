using System;
using System.Collections.Generic;
using MVC_Console.Models;
namespace MVC_Console.Views
{
    public class ProdutoView
    {
        public void ListarTodos(List<Produto> produtos)
        {
            foreach (var item in produtos)
            {
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Marca: {item.Nome}"); 
                Console.WriteLine($"Preço: {item.Preco}"); 
                Console.WriteLine($"");
            }
        }
            public Produto CadastrarProduto()
            {
                Produto prod = new Produto();

                Console.Write($"Digite o codigo do produto: ");
                prod.Codigo = int.Parse(Console.ReadLine());

                Console.Write($"Digite o nome do produto: ");
                prod.Nome = Console.ReadLine();

                Console.Write($"Digite o preço do produto: ");
                prod.Preco = float.Parse(Console.ReadLine());
                Console.WriteLine($"");

                return prod;
            }
    }
}
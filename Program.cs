using System;
using MVC_Console.Controller;
using MVC_Console.Models;

namespace MVC_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController produtoController = new ProdutoController();
            produtoController.Cadastrar();
            produtoController.MostrarProdutos();
        }
    }
}

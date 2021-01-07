using System.Collections.Generic;
using MVC_Console.Models;
using MVC_Console.Views;

namespace MVC_Console.Controller
{
    public class ProdutoController
    {
        Produto produto = new Produto();
        ProdutoView view = new ProdutoView();

        public void MostrarProdutos()
        {
            List<Produto> todos = produto.Ler();
            view.ListarTodos(todos);
        }

        public void Cadastrar()
        {
            produto.Inserir( view.CadastrarProduto() );
        }
    }
}
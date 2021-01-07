using System;
using System.Collections.Generic;
using System.IO;
namespace MVC_Console.Models
{
    public class Produto
    {
        public int Codigo { get; set; }
        
        public string Nome { get; set; }
        
        public float Preco { get; set; }
        
        private const string PATH = "Database/Produto.csv";

        public Produto()
        {
            string pasta = PATH.Split("/")[0];

            // Verificamos se a pasta não existe

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }
        }

        public List<Produto> Ler()
        {
            List<Produto> produtos = new List<Produto>();

            // Pegar info do CSV

            string[] linhas = File.ReadAllLines(PATH);

            //Separar atributos pelo ";"
            foreach (var item in linhas)
            {
                string[] atributo = item.Split(";");
                
                // Criamos um prod vazio para poder colocar na lista final de produtos
                Produto prod = new Produto();
                prod.Codigo = int.Parse(atributo[0]);
                prod.Nome = atributo[1];
                prod.Preco = float.Parse(atributo[2]);
                produtos.Add(prod);
            }

            return produtos;
        }

        public void Inserir(Produto p)
        {
            string[] linhas = {PrepararLinhaCSV(p)};

            File.AppendAllLines(PATH, linhas);
        }
        public string PrepararLinhaCSV(Produto prod)
        {
            return $"\n{prod.Codigo};{prod.Nome};{prod.Preco}";
        }
    }
}
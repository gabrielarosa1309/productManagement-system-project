using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productManagement_system_project
{
    public class Produto
    {
        //propriedades
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public Marca Marca { get; set; }
        public Usuario CadastroPor { get; set; }
        public static List<Produto> produto = new List<Produto>();

        //costrutor
        Produto(int codigo, string nomeProduto, float preco, Marca marcaEncontrada)
        {
            Codigo = codigo;
            NomeProduto = nomeProduto;
            Preco = preco;
            Marca = marcaEncontrada;
        }

        //metodos
        public static void Cadastrar()
        {
            Console.WriteLine($"Vamos cadastrar o produto!");
            Console.Write($"Insira um código:");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write($"Insira um nome:");
            string nomeProduto = Console.ReadLine();
            Console.Write($"Insira um preço:");
            float preco = float.Parse(Console.ReadLine());
            Console.Write($"Insira o código da marca:");
            int codigoMarca = int.Parse(Console.ReadLine());
            Marca marcaEncontrada = Marca.marca.Find(item => item.Codigo == codigoMarca);
            
            produto.Add(
                new Produto(codigo, nomeProduto, preco, marcaEncontrada)
            );

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Produto cadastrado com sucesso!");
            Console.ResetColor();
        }
        public static void Listar()
        {
            Console.WriteLine($"Lista de produtos:");
            Console.WriteLine();
            foreach (var item in produto)
            {
                Console.WriteLine(@$"
                Código: {item.Codigo} 
                Nome: {item.NomeProduto}
                Preco: {item.Preco:C}
                Marca: {item.Marca.NomeMarca}");
            }
        }
        public static void Deletar(int codigoProduto)
        {
            Produto produtoEncontrado = produto.Find(item => item.Codigo == codigoProduto);
            int index = produto.IndexOf(produtoEncontrado);
            produto.RemoveAt(index);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Produto deletado!");
            Console.ResetColor();
        }
    }
}
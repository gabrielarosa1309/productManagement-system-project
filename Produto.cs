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
            Marca marcaEncontrada = Marca.marca.Find(item => item.Codigo == codigo);
            
            produto.Add(
                new Produto(codigo, nomeProduto, preco, marcaEncontrada)
            );

            Console.WriteLine();
            Console.WriteLine($"Produto cadastrado com sucesso!");
        }
        public static void Listar()
        {

        }
        public static void Deletar()
        {
            
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productManagement_system_project
{
    public class Marca
    {
        //propridades
        public int Codigo;
        public string NomeMarca;
        public DateTime DataCadastro;
        public static List<Marca> marca = new List<Marca>();

        //contrutor
        public Marca(int codigo, string nomeMarca)
        {
            Codigo = codigo;
            NomeMarca = nomeMarca;
        }

        //métodos
        public static void Cadastrar()
        {
            Console.WriteLine($"Vamos cadastrar a marca!");
            Console.Write($"Insira um código:");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write($"Insira um nome:");
            string nomeMarca = Console.ReadLine();

            marca.Add(
                new Marca(codigo, nomeMarca)
            );

            Console.WriteLine();
            Console.WriteLine($"Marca cadastrada com sucesso!");
        }

        public static void Listar()
        {
            Console.WriteLine($"Lista de marcas:");
            Console.WriteLine();
            foreach (var item in marca)
            {
                Console.WriteLine($"Código: {item.Codigo}, Nome: {item.NomeMarca}");
            }
        }

        public static void Deletar(int codigoMarca)
        {
            Marca marcaEncontrada = marca.Find(item => item.Codigo == codigoMarca);
            int index = marca.IndexOf(marcaEncontrada);
            marca.RemoveAt(index);

            Console.WriteLine($"Marca deletada!");
        }
    }
}
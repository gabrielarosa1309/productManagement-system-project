using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productManagement_system_project
{
    public class Login
    {
        //propriedades
        public bool logado;

        //construtor
        public Login()
        {

        }

        //métodos
        char Menu()
        {
            Console.WriteLine($"---------------------------------------------");
            Console.WriteLine($"¦          Gerenciador de Produtos          ¦");
            Console.WriteLine($"---------------------------------------------");
            Console.WriteLine();

            Console.WriteLine(@$"
            Escolha uma operação:
            1 - Cadastrar marca
            2 - Listar marca 
            3 - Remover marca
            4 - Cadastrar produto
            5 - Listar produto
            6 - Remover produto
            7 - Sair
            ");

            return char.Parse(Console.ReadLine());
            
            char resposta = '0';

            do
            {
            
            } while (true);
        }

        public string Logar()
        {
            Console.Write($"Insira seu email:");
            string email = Console.ReadLine();
            Console.Write($"Insira sua senha:");
            string senha = Console.ReadLine();

            return "Você foi logado!";
        }

        public string Deslogar()
        {
            return "Você foi deslogado!";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productManagement_system_project
{
    public class Usuario
    {
        //propriedades
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }

        //construtor
        public Usuario()
        {
            Cadastrar();
        }

        //métodos
        public void Cadastrar()
        {
            Console.WriteLine($"Bem vindo ao sistema de gerenciamento de produtos! Vamos iniciar nossas operações cadastrando o usuário.");
            Console.Write($"Insira seu nome:");
            this.Nome = Console.ReadLine();
            Console.Write($"Insira seu e-mail:");
            this.Email = Console.ReadLine();
            Console.Write($"Insira sua senha:");
            this.Senha = Console.ReadLine();
            Console.WriteLine();
        }

        public void Deletar()
        {
            
        }
    }
}


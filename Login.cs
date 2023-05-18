using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productManagement_system_project
{
    public class Login
    {
        //propriedades
        public bool Logado;

        //construtor
        public Login()
        {
            Usuario user = new Usuario();
            Logar(user);
            if (Logado)
            {
                Menu();
            }
        }

        //métodos
        public void Logar(Usuario usuario)
        {
            Console.Write($"Insira seu email:");
            string email = Console.ReadLine();
            Console.Write($"Insira sua senha:");
            string senha = Console.ReadLine();

            if (email == usuario.Email && senha == usuario.Senha)
            {
                this.Logado = true;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Login efetuado com sucesso!");
                Console.ResetColor();
            }
            else
            {
                this.Logado = false;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Usuário ou senha incorretos, tente novamente!");
                Console.ResetColor();
            }
        }

        public void Menu()
        {
            string opcao = Console.ReadLine();
            
            do
            {
                Console.WriteLine($"---------------------------------------------");
                Console.WriteLine($"¦          Gerenciador de Produtos          ¦");
                Console.WriteLine($"---------------------------------------------");
                Console.WriteLine();

                Console.WriteLine(@$"
                Escolha uma operação:

                1 - Cadastrar marca
                2 - Listar marcas 
                3 - Remover marca
                ---------------------
                4 - Cadastrar produto
                5 - Listar produtos
                6 - Remover produto

                7 - Sair
                ");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Marca.Cadastrar();
                        break;

                    case "2":
                        Marca.Listar();
                        break;

                    case "3":
                        Console.Write($"Insira o código da marca que deseja deletar:");
                        int codigoMarca = int.Parse(Console.ReadLine());
                        Marca.Deletar(codigoMarca);
                        break;

                    case "4":
                        Produto.Cadastrar();
                        break;

                    case "5":
                        Produto.Listar();
                        break;

                    case "6":
                        Console.Write($"Insira o código do produto que deseja deletar:");
                        int codigoProduto = int.Parse(Console.ReadLine());
                        Produto.Deletar(codigoProduto);
                        break;

                    case "7":
                        Console.WriteLine($"Obrigada por usar o programa!");
                        break;
                }

            } while (opcao != "7");
        }
    }
}
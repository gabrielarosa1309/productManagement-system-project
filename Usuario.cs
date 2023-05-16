using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productManagement_system_project
{
    public class Usuario
    {
        //propriedades
        public int Codigo;
        public string Nome;
        public string Email;
        public string Senha;
        public DateTime DataCadastro;
        public List<Usuario> novoUsuario = new List<Usuario>();

        //construtor
        public Usuario(int codigo, string nome, string email, string senha)
        {
            Codigo = codigo;
            Nome = nome;
            Email = email;
            Senha = senha;
            DataCadastro = DateTime.Now;
        }

        //métodos
        public string Cadastrar(Usuario usuario)
        {
            novoUsuario.Add(usuario);
            return "Usuário cadastro com sucesso!";
        }

        public string Deletar(Usuario usuario)
        {
            novoUsuario.Remove(usuario);
            return "Usuário deletado!";
        }
    }
}
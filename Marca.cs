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
        public List<Marca> novaMarca = new List<Marca>();

        //contrutor
        public Marca(int codigo, string nomeMarca)
        {
            Codigo = codigo;
            NomeMarca = nomeMarca;
            DataCadastro = DateTime.Now;
        }

        //métodos
        public string Cadastrar(Marca marca)
        {
            novaMarca.Add(marca);
            return "Marca registrada!";
        }

        public void Listar()
        {
            List<Marca> novaMarca = new List<Marca>();
        }

        public string Deletar(Marca marca)
        {
            novaMarca.Remove(marca);
            return "Marca deletada!";
        }
    }
}
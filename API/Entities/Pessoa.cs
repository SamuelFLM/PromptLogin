using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Pessoa
    {

        public Pessoa(string nome, string email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Registro = DateTime.Now;
        }
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public DateTime Registro { get; private set; }

        public void Alterar(string nome, string email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
        }

    }
}
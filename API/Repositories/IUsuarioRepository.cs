using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Repositories
{
    public interface IUsuarioRepository
    {
        List<Pessoa> ObterTodos();
        Pessoa ObterPorId(int id);
        Pessoa ObterPorNome(string nome);
        Pessoa ObterPorEmail(string email);
        void Adicionar(Pessoa pessoa);
        void Alterar(Pessoa pessoa);
        void Deletar(Pessoa pessoa);
    }
}
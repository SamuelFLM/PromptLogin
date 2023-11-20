using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using API.Persistence;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly UsuarioContext _context;

        public UsuarioRepository(UsuarioContext context)
        {
            _context = context;
        }

        public void Adicionar(Pessoa pessoa)
        {
            _context.User.Add(pessoa);
            _context.SaveChanges();
        }

        public void Alterar(Pessoa pessoa)
        {
            _context.User.Update(pessoa);
            _context.SaveChanges();
        }

        public void Deletar(Pessoa pessoa)
        {
            _context.User.Remove(pessoa);
            _context.SaveChanges();
        }
     
        public Pessoa ObterPorId(int id)
        {
            return _context.User.SingleOrDefault(e => e.Id == id);
        }

        public List<Pessoa> ObterTodos()
        {
            return _context.User.AsNoTracking().ToList();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Src.DTOs;

namespace Src.Entities.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>> ObterTodos();
        Task<User> ObterPorId(int id);

        Task<User> Criar(AdicionarUser user);
        Task<User> Atualizar(AtualizarUser user, int id);

        Task<bool> Deletar(int id);
    }
}
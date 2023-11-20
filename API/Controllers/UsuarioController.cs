using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using API.Models;
using API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("v1/user")]
    public class UsuarioController : ControllerBase
    {

        private readonly IUsuarioRepository _repository;
        public UsuarioController(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult ObterTodos()
        {
            var users = _repository.ObterTodos();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var user = _repository.ObterPorId(id);

            if (user is null)
                return NotFound();

            return Ok(user);
        }

        [HttpPost]
        public IActionResult Adicionar(AddUser model)
        {
            Pessoa pessoa = new(model.nome, model.email, model.senha);

            _repository.Adicionar(pessoa);

            return CreatedAtAction(nameof(ObterPorId), new { id = pessoa.Id }, pessoa);

        }

        [HttpPut("{id}")]
        public IActionResult Alterar(int id ,UpdateUser model){
            var user = _repository.ObterPorId(id);

            if (user is null)
                return NotFound();

            user.Alterar(model.nome, model.email, model.senha);

            _repository.Alterar(user);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id){
            var user = _repository.ObterPorId(id);

            if (user is null)
                return NotFound();

            _repository.Deletar(user);

            return NoContent();
        }

    }
}
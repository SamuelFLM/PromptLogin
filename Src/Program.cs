
using Src.Entities;
using Src.Entities.Services;
using Src.DTOs;
using Src.Models;
using System.Reflection.Metadata;

internal class Program
{

    private static async Task Main(string[] args)
    {

        UserService service = new();

        var users = await service.ObterTodos();

        List<User> usuario = new();

        foreach (var user in users)
            usuario.Add(user);

        Fluxo fluxo = new(usuario);

        fluxo.TelaInicial();

    }






    // User user = await service.ObterPorId(1);
    // List<string> dados = new()
    // {
    //     user.Id.ToString(),
    //     user.Nome,
    //     user.Email,
    //     user.senha
    // };

    // dados.ForEach(l => Console.WriteLine(l));


    // AtualizarUser atualizar = new AtualizarUser("Samuca", "Samuca@gmail.com", "12345");

    // var put = await service.Atualizar(atualizar, 3);


    // var deletar = await service.Deletar(3);

    // if (deletar)
    //     Console.WriteLine("Usuario excluido!");

}



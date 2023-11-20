
using Src.Entities;
using Src.Entities.Services;

internal class Program
{
    private static async Task Main(string[] args)
    {
        UserService service = new();

        User user = await service.ObterPorId(1);

        var users = await service.ObterTodos();

        List<string> dados = new()
        {
            user.Id.ToString(),
            user.Nome,
            user.Email,
            user.senha
        };

        dados.ForEach(l => Console.WriteLine(l));


    }
}

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
        Menu menu = new();

        var u = await service.ObterTodos();

        bool validation = true;
        byte opcao = 0;
        do
        {
            menu.Principal();
            byte.TryParse(Console.ReadLine(), out byte resultado);

            if (resultado != 0 && resultado is 1 || resultado is 2)
            {
                opcao = resultado;
                validation = false;
            }
            else
            {
                Console.WriteLine("\t\nPor favor! Digite apenas 1 ou 2. Para sair -> 'Ctrl' + 'c'".ToUpper());
                Console.ReadKey();
            }

        } while (validation);

        switch (opcao)
        {
            case 1:
                break;

            case 2:
                break;

            default:
                break;
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



}


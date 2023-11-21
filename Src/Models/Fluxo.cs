using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Src.Entities;

namespace Src.Models
{
    public class Fluxo
    {
        public Fluxo(List<User> users)
        {
            Users = users;
            Menu = new Menu();
        }
        public List<User> Users { get; set; }
        public Menu Menu { get; set; }
        public byte Opcao { get; set; }
        public bool Validacao { get; set; }

        public void TelaInicial()
        {
            do
            {
                Menu.Principal();
                byte.TryParse(Console.ReadLine(), out byte resultado);

                if (resultado != 0 && resultado is 1 || resultado is 2)
                {
                    Opcao = resultado;
                    Validacao = false;
                    EscolhaUsuario();
                }
                else
                {
                    Console.WriteLine("\t\nPor favor! Digite apenas 1 ou 2. Para sair -> 'Ctrl' + 'c'".ToUpper());
                    Console.ReadKey();
                }

            } while (Validacao);

        }

        public void EscolhaUsuario()
        {
            switch (Opcao)
            {
                case 1:

                    Validacao = true;
                    while (Validacao)
                    {
                        Menu.Login();
                        Console.Write("\nEmail: ");
                        string email = Console.ReadLine();

                        Console.Write("\nSenha: ");
                        string senha = Console.ReadLine();

                        if (email is "123" && senha is "123")
                            Console.WriteLine("Entrou");

                        Menu.Continuar();
                        byte.TryParse(Console.ReadLine(), out byte opcao);

                        _ = opcao is 1 ? Validacao = true : Validacao = false;
                    }
                    TelaInicial();
                    break;

                case 2:
                    Validacao = true;
                    while (Validacao)
                    {
                        Menu.Registrar();
                        Console.Write("\nNome: ");
                        string nome = Console.ReadLine();

                        Console.Write("\nEmail: ");
                        string email = Console.ReadLine();

                        Console.Write("\nSenha: ");
                        string senha = Console.ReadLine();

                        // validacao

                        Console.WriteLine("\nCadastro realizado com sucesso.\n".ToUpper());
                    }
                    break;

                default:
                    break;
            }
        }
    }
}
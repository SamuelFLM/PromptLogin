using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Src.Models
{
    public class Menu
    {

        public void Principal()
        {
            Console.Clear();
            Console.WriteLine("*****************************************");
            Console.WriteLine("\t\tbem vindo\n".ToUpper());
            Console.WriteLine("1 - login\n".ToUpper());
            Console.WriteLine("2 - register\n\n".ToUpper());
            Console.Write("digite: ".ToUpper());
        }

        public void Principal1(string nome)
        {
            Console.Clear();
            Console.WriteLine("*****************************************");
            Console.WriteLine($"\t\tbem vindo {nome}\n".ToUpper());
        }

        public void Login()
        {
            Console.Clear();
            Console.WriteLine("*****************************************");
            Console.WriteLine($"\t\tlogin\n".ToUpper());
        }


        public void Registrar()
        {
            Console.Clear();
            Console.WriteLine("*****************************************");
            Console.WriteLine($"\t\tregister\n".ToUpper());
        }

        public void ObterTodos()
        {

        }
        public void ObterPorId()
        {

        }


        public void Criar()
        {

        }

        public void Atualizar()
        {

        }


        public void Deletar()
        {

        }

        public void Continuar(){
            Console.WriteLine("\t\nParece que tem algo de errado deseja continuar?".ToUpper());
            Console.WriteLine("1 - sim\n".ToUpper());
            Console.WriteLine("2 - voltar\n".ToUpper());
            Console.Write("Digite: ");
        }

    }
}
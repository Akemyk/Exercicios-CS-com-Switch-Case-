using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSwitch
{
    internal class MenuOpcoesEx4
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("Olá, Mundo! (a)");
            Console.WriteLine("Bem-vindo ao C# (b)");
            Console.WriteLine("Sair do programa (c)");

            char mensagem = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------------------");
            switch(mensagem)
            {
                case 'a':
                    Console.WriteLine("Olá, mundo");
                    break;
                case 'b':
                    Console.WriteLine("Bem-vindo ao C#");
                    break;
                default:
                    Console.WriteLine("Nenhuma mensagem correspondente");
                    break;
            }
        }
    }
}

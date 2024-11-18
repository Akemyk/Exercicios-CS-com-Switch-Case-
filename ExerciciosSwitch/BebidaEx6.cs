using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSwitch
{
    internal class BebidaEx6
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a letra correspondente para a bebida:");
            Console.WriteLine("Café (a)");
            Console.WriteLine("Chá (b)");
            Console.WriteLine("Suco (c)");
            Console.WriteLine("Refrigerante (d)");

            char bebida = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------");

            switch(bebida)
            {
                case 'a':
                    Console.WriteLine("Você escolheu café");
                    break;
                case 'b':
                    Console.WriteLine("Você escolheu chá");
                    break;
                case 'c':
                    Console.WriteLine("Você escolheu suco");
                    break;
                case 'd':
                    Console.WriteLine("Você escolheu refrigerante");
                    break;
                default:
                    Console.WriteLine("Nenhuma bebida correspondente");
                    break;

            }
        }
    }
}

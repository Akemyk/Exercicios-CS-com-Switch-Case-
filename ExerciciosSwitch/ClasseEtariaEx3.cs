using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSwitch
{
    internal class ClasseEtariaEx3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade");
            int idade = Convert.ToInt16(Console.ReadLine());

            switch(idade)
            {
                case <= 12:
                    Console.WriteLine("Criança");
                    break;
                case <=17:
                    Console.WriteLine("Adolescente");
                    break;
                case <= 59:
                    Console.WriteLine("Adulto");
                    break;
                default:
                    Console.WriteLine("Idoso");
                    break;
            }
        }
    }
}

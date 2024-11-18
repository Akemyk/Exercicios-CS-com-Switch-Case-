using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSwitch
{
    internal class FaixaEtariaEx9
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a classificação:");
            Console.WriteLine("G");
            Console.WriteLine("PG");
            Console.WriteLine("PG");
            Console.WriteLine("R");
            Console.WriteLine("------------------------------------------------");
            string classificacao = Console.ReadLine();
            Console.WriteLine("------------------------------------------------");
            switch (classificacao)
            {
                case "G":
                    Console.WriteLine("Livre para todo o público");
                    break;
                case "PG":
                    Console.WriteLine("Para maiores de 10 anos");
                    break;
                case "R":
                    Console.WriteLine("Para maiores que 18");
                    break;
                default:
                    Console.WriteLine("Nenhuma classificação correspondente");
                    break;
            }
        }
    }
}

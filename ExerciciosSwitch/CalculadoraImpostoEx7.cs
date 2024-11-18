using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSwitch
{
    internal class CalculadoraImpostoEx7
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a faixa salarial");
            double salario = Convert.ToDouble(Console.ReadLine());
            

            switch(salario)
            {
                case <= 1500:
                    Console.WriteLine("O imposto é " + (salario*0.05));
                    break;
                case <= 3000:
                    Console.WriteLine("O imposto é " + (salario*0.10));
                    break;
                default:
                    Console.WriteLine("O imposto é " + (salario*0.15));
                    break;
            }
        }
    }
}

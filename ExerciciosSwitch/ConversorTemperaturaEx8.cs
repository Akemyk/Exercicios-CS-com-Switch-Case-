using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSwitch
{
    internal class ConversorTemperaturaEx8
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite 'a' para converter Celsius para Fahrenheit");
            Console.WriteLine("Digite 'b' para converter Fahrenheit para Celsius");
            char conversao = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("---------------------------------------------------");

            switch(conversao)
            {
                case 'a':
                    Console.WriteLine("Digite a temperatura em Celsius");
                    double celsius = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("A temperaruta em Fahrenheit é " + ((celsius * 1.8) + 32));
                    break;
                case 'b':

                    Console.WriteLine("Digite a temperatura em Fahrenheit");
                    double fahrenheit = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("A temperatura em Celsius é " + ((fahrenheit-32)/1.8));
                    break;
                default:
                    Console.WriteLine("Nenhum valor correspondente");
                    break;
            }
        }
    }
}

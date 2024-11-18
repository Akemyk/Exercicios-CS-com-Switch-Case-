using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSwitch
{
    internal class OperacoesEx2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite outro número");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite um operador aritmético (+,-,*,/)");
            char operador = Convert.ToChar(Console.ReadLine()); 

            switch (operador)
            {
                case '+':
                    Console.WriteLine("Você escolheu soma: " + (num1+num2));
                    break;

                case '-':
                    Console.WriteLine("Você escolheu subtração: " + (num1-num2));
                    break;

                case '*':
                    Console.WriteLine("Você escolheu mutiplicação " + (num1*num2));
                    break;

                case '/':
                    Console.WriteLine("Você escolheu divisão: " + (num1/num2));
                    break;

                default:
                    Console.WriteLine("Nenhuma operação correspondente");
                    break;

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSwitch
{
    internal class NotaAlunoEx5
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a nota do aluno de 0 a 10");
            int nota = Convert.ToInt16(Console.ReadLine());
           
            switch(nota)
            {
                case <= 2:
                    Console.WriteLine("F");
                    break;
                case <=4:
                    Console.WriteLine("D");
                    break;
                case <= 6:
                    Console.WriteLine("C");
                    break;
                case <= 8:
                    Console.WriteLine("B");
                    break;
                default:
                    Console.WriteLine("A");
                    break;
            }


        }
    }
}

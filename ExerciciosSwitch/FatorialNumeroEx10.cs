using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSwitch
{
    internal class FatorialNumeroEx10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma operação:");
            Console.WriteLine("1 - Calcular Fatorial");
            
            int fatorial = 1;
            // Lê a opção do usuário
            int escolha = Convert.ToInt32(Console.ReadLine());
                
            switch(escolha)
            {
                case 1:
                    Console.WriteLine("Digite um número");
                    int num = Convert.ToInt16(Console.ReadLine());

                    for (int i = 1; i <= num; i++)
                    {
                         fatorial *= i; 
                    }
                    Console.WriteLine("O fatorial do número " + num + "é " + fatorial);
                    break;
                default:
                    Console.WriteLine("Nenhum valor correspondido");
                    break;
            }
        }
    

    }
}

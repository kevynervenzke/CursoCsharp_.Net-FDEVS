using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplosde10array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Mult10 = new int[15];
            int[] numeros = new int[15];
            Console.WriteLine("===================================");
            Console.WriteLine("      NÚMEROS MÚLTIPLOS DE 10      ");
            Console.WriteLine("===================================");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                numeros[i] = int.Parse(Console.ReadLine());
                if (numeros[i]%10 == 0)
                {
                    Mult10[i] = i + 1;
                }

            }
            Console.WriteLine("===================================");
            Console.WriteLine("           VETOR INTEIRO           ");
            Console.WriteLine("===================================");
            for (int contador = 0; contador < numeros.Length; contador++)
            {
                Console.WriteLine($"{contador + 1}º Número: {numeros[contador]}");
            }
            Console.WriteLine("===================================");
            Console.WriteLine("      POSIÇÕES MÚLTIPLOS DE 10     ");
            Console.WriteLine("===================================");
            for (int j = 0; j < Mult10.Length; j++)
            {
                if (Mult10[j] != 0)
                {
                    Console.WriteLine($"{Mult10[j]}");
                }
            }

        }
    }
}

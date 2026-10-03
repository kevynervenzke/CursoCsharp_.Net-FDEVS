using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10numerospar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Numeros = new int[10];
            int[] NumerosPar = new int[10];
            int[] Posicao = new int[10];
            Console.WriteLine("===================================");
            Console.WriteLine("           NÚMEROS PARES           ");
            Console.WriteLine("===================================");
            for (int i = 0; i < Numeros.Length; i++)
            {

                Console.Write($"Digite o {i + 1}º número: ");
                Numeros[i] = int.Parse(Console.ReadLine());
                if (Numeros[i]%2 == 0)
                {
                    NumerosPar[i] = Numeros[i];
                    Posicao[i] = i + 1;
                }
                Console.Clear();
            }
            Console.WriteLine("===================================");
            Console.WriteLine("           NÚMEROS PARES           ");
            Console.WriteLine("===================================");
            for (int j = 0; j < NumerosPar.Length; j++)
            {
                if (NumerosPar[j] != 0)
                {
                    Console.WriteLine($"{Posicao[j]} - {NumerosPar[j]}");
                }
            }

        }
    }
}

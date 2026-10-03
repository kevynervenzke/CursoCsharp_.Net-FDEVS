using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetorordemcrescente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] Numeros = new int[20];
            Console.WriteLine("===================================");
            Console.WriteLine("ARRAY ALEATÓRIO EM ORDEM CRESCENTE ");
            Console.WriteLine("===================================");
            for(int i = 0; i < Numeros.Length; i++)
            {
                Numeros[i] = rnd.Next(1, 100);
            }
            Console.WriteLine("===================================");
            Console.WriteLine("          ORDEM ALEATÓRIA          ");
            Console.WriteLine("===================================");
            for(int j = 0; j < Numeros.Length; j++)
            {
                Console.Write($"{Numeros[j]}.. ");
            }
            Console.WriteLine();
            Console.WriteLine("===================================");
            Console.WriteLine("          ORDEM CRESCENTE          ");
            Console.WriteLine("===================================");
            Array.Sort(Numeros);
            for(int k = 0; k < Numeros.Length; k++)
            {
                Console.Write($"{Numeros[k]}.. ");
            }
            Console.WriteLine();
            Console.WriteLine("===================================");
            Console.WriteLine("         ORDEM DECRESCENTE         ");
            Console.WriteLine("===================================");
            Array.Reverse(Numeros);
            for (int c = 0; c < Numeros.Length; c++)
            {
                Console.Write($"{Numeros[c]}.. ");
            }
        }
    }
}

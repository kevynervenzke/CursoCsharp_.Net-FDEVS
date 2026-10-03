using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetor5e3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            Console.WriteLine("===============================");
            Console.WriteLine("          Vetor 5 e 3          ");
            Console.WriteLine("===============================");
            for(int i = 0; i < numeros.Length; i+=2)
            {
                numeros[i] = 5;
            }
            for (int j = 1; j < numeros.Length; j+=2)
            {
                numeros[j] = 3;
            }
            for (int contador = 0; contador < numeros.Length; contador++)
            {
                Console.Write($"{numeros[contador]}..  ");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetorautomatico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======================================");
            Console.WriteLine("            Vetor 5 até 50            ");
            Console.WriteLine("======================================");
            int[] numeros = new int[10];
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = (5 * (i +1));
            }
            for (int contador = 0; contador < numeros.Length; contador++)
            {
                Console.Write($"{numeros[contador]}.. ");
            }
        }
    }
}

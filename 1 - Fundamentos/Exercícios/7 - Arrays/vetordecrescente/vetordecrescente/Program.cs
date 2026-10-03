using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetordecrescente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            Console.WriteLine("====================================");
            Console.WriteLine("        Vetor Decrescente           ");
            Console.WriteLine("====================================");
            for(int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = (9 - i);
            }
            for(int contador = 0; contador < numeros.Length; contador++)
            {
                Console.Write($"{numeros[contador]}.. ");
            }
        }
    }
}

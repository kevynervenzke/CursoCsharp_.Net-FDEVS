using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetor999
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            int[] numeros = new int[8];
            Console.WriteLine("====================================");
            Console.WriteLine("      Colocando 999 no vetor        ");
            Console.WriteLine("====================================");
            for (int contador = 0; contador < numeros.Length; contador++)
            {
                numeros[contador] = 999;
            }
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"{numeros[i]}.. ");
            }
        }
    }
}

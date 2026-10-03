using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numerosaleatoriosarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] valores = new int[8];
            for (int i = 0; i < valores.Length; i++)
            {
                valores[i] = rnd.Next(1, 101);
            }
            for (int contador = 0; contador < valores.Length; contador++)
            {
                Console.Write($"{valores[contador]}.. ");
            }
            Console.WriteLine();
            Console.WriteLine("Ordem Crescente");
            Array.Sort(valores);
            for(int j = 0; j < valores.Length; j++)
            {
                Console.Write($"{valores[j]}.. ");
            }
            Console.WriteLine();
            Console.WriteLine("Ordem Decrescente");
            Array.Reverse(valores);
            for (int k = 0; k < valores.Length; k++)
            {
                Console.Write($"{valores[k]}.. ");
            }
        }
    }
}

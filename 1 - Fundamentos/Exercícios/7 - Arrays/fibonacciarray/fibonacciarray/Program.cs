using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacciarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] fibonacci = new int[16];
            Console.WriteLine("======================================");
            Console.WriteLine("           Fibonacci Array            ");
            Console.WriteLine("======================================");

            int n1 = 0;
            int n2 = 1;
            for (int i = 0; i < fibonacci.Length; i++)
            {
                int n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
                fibonacci[i] = n3;
            }
            Console.Write("0.. 1.. ");
            for (int contador = 0; contador < fibonacci.Length; contador++)
            {
                Console.Write($"{fibonacci[contador]}.. ");
            }
        }
    }
}

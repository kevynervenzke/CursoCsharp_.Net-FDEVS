using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace antecessoresucessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Antecessor e Sucessor");
            Console.Write("Digite um número: ");
            int n = int.Parse(Console.ReadLine());
            int na = (n - 1);
            int nd = (n + 1);
            Console.WriteLine($"O antecessor de {n} é {na}");
            Console.WriteLine($"O sucessor de {n} é {nd}");

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace soma2numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int n2 = int.Parse(Console.ReadLine());
            int s = n1 + n2;
            Console.WriteLine("A soma de " + n1 + " com " + n2 + " é " + s);
        }
    }
}

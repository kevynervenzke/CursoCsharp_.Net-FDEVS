using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace tercapartedobro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            float n = float.Parse(Console.ReadLine());
            float d = (n * 2);
            float t = (n / 3);
            Console.WriteLine($"O dobro de {n} é {d}");
            Console.WriteLine($"A terça parte de {n} é {t}");

        }
    }
}

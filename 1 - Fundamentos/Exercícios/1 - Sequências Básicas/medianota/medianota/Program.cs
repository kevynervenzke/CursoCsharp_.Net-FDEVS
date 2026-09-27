using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace medianota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Média de Notas");
            Console.Write("Primeira Nota: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.Write("Segunda Nota: ");
            float n2 = float.Parse(Console.ReadLine());
            float m = (n1 + n2) / 2;
            Console.WriteLine($"A média entre {n1} e {n2} é {m:F2}");

        }
    }
}


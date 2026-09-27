using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contadordivisivelpor4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Números Divisíveis por 4");
            int contador = 30;
            while (contador >= 1)
            {
                if (contador % 4 == 0)
                {
                    Console.Write($"[{contador}].. ");
                }
                else
                {
                    Console.Write($"{contador}.. ");
                }
                contador -= 1;
            }
            Console.WriteLine("\nFim do programa");
        }
    }
}


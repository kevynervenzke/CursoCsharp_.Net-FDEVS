using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contadorsomadepares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Somador de Pares");
            int contador = 6;
            int total = 0;
            while (contador <= 100)
            {
                total = total + contador;
                contador += 2;
            }
            Console.WriteLine($"Total da soma de 6 a 100: {total}");
        }
    }
}


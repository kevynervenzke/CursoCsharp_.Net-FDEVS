using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace totalpareimpar6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("6 números par ou ímpar");
            int contador = 1;
            int totpar = 0;
            int totimpar = 0;
            while (contador <= 6)
            {
                Console.Write($"Digite o {contador}º número: ");
                int valor = int.Parse(Console.ReadLine());
                if (valor % 2 == 0)
                {
                    totpar++;
                }
                else
                {
                    totimpar++;
                }
                contador++;
            }
            Console.WriteLine($"Total de números pares: {totpar}");
            Console.WriteLine($"Total de números ímpares: {totimpar}");

        }
    }
}

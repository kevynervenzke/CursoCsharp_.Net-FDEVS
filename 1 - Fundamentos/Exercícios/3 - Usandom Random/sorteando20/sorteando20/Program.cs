using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorteando20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Sorteando 20 números");
            int contador = 1;
            int tot5 = 0;
            int tot3 = 0;
            Console.WriteLine($"Número sorteados: ");
            while (contador <= 20)
            {
                int sorteio = random.Next(1, 10);
                if (sorteio > 5)
                {
                    tot5++;
                }
                else if (sorteio % 3 == 0)
                {
                    tot3++;
                }
                Console.Write($"{sorteio}.. ");
                contador++;
            }
            Console.WriteLine();
            Console.WriteLine($"Total de números maiores que 5: {tot5}");
            Console.WriteLine($"Total de números divisíveis por 3: {tot3}");
        }
    }
}

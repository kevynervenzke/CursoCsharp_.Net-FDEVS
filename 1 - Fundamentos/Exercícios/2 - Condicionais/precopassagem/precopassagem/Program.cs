using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace precopassagem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valor da Passagem");
            Console.Write("Qual a distância (Km): ");
            float d = float.Parse(Console.ReadLine());
            if (d < 200)
            {
                double taxa = 0.50;
                double valor = (0.50 * d);
                Console.WriteLine($"A viagem de distância de {d:F2}Km vai ter a taxa de {taxa:F2}R$ por Km totalizando {valor:F2}");
            }
            else
            {
                double taxa = 0.45;
                double valor = (0.45 * d);
                Console.WriteLine($"A viagem de distância de {d:F2}Km vai ter a taxa de {taxa:F2}R$ por Km totalizando {valor:F2}");
            }
        }
    }
}

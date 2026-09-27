using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace alugueldecarros
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Cobrança Aluguel de Carros");
            Console.Write("Quilômetros percorridos: ");
            float km = float.Parse(Console.ReadLine());
            Console.Write("Dias alugados: ");
            int d = int.Parse(Console.ReadLine());
            double p = (90 * d) + (km * 0.20);
            Console.WriteLine($"Foram {d} dias rodados e {km}Km percorridos, portanto o preço é {p:F2}R$");
        }
    }
}


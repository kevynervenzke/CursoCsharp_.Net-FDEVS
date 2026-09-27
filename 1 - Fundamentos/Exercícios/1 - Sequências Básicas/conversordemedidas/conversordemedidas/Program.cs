using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace conversordemedidas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor de Medidas: ");
            Console.Write("Digite uma distância em metros: ");
            float m = float.Parse(Console.ReadLine());
            float km = (m / 1000);
            float hm = (m / 100);
            float dam = (m / 10);
            float dm = (m * 10);
            float cm = (m * 100);
            float mm = (m * 1000);
            Console.WriteLine($"A distância de {m} corresponde a:");
            Console.Write($"{km}Km\n{hm}Hm\n{dam}Dam\n{dm}dm\n{cm}cm\n{mm}mm\n");

        }
    }
}

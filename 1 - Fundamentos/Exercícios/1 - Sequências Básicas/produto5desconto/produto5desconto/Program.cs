using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace produto5desconto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Preço de produtos com 5% de desconto");
            Console.Write("Digite o preço atual: ");
            float pa = float.Parse(Console.ReadLine());
            float np = (pa - (pa * 5 / 100));
            Console.WriteLine($"O novo preço do produto é {np}");
        }
    }
}


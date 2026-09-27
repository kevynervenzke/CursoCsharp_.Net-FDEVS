using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace conversorrealdolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos dólares posso comprar? ");
            Console.WriteLine("Valor do Dólar: 3,45R$");
            Console.Write("Quanto você tem em reais: ");
            float r = float.Parse(Console.ReadLine());
            float d = (r / 3.45f);
            Console.WriteLine($"Com {r}R$ você consegue comprar {d:F2}US$");

        }
    }
}

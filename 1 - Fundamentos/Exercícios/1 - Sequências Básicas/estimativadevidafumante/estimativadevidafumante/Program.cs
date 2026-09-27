using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace estimativadevidafumante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estimativa de vida de um fumante");
            Console.Write("Quantos cigarros fuma por dia? ");
            int cp = int.Parse(Console.ReadLine());
            Console.Write("Quantos anos já fumou? ");
            int a = int.Parse(Console.ReadLine());
            int d = a * 365;
            int pd = cp * 10;
            int m = d * pd;
            int diasDeVida = (m / 60) / 24;
            Console.WriteLine($"No total você perdeu {diasDeVida} dias de vida.");
        }
    }
}

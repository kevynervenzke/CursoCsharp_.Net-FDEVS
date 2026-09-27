using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoraidade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de idade");
            Console.Write("Digite sua idade: ");
            int i = int.Parse(Console.ReadLine());
            if (i >= 0 && i <= 11)
            {
                Console.WriteLine("Você é uma criança!");
            }
            else if (i >= 12 && i <= 18)
            {
                Console.WriteLine("Você é um adolescente!");
            }
            else if (i >= 19 && i <= 60)
            {
                Console.WriteLine("Você é um adulto!");
            }
            else
            {
                Console.WriteLine("Você é um idoso!");
            }
            Console.ReadLine();
        }
    }
}

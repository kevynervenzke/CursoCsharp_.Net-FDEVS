using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contadorinteligente2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contador Inteligente 2.0");
            Console.Write("Digite o valor inicial: ");
            int vi = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor final: ");
            int vf = int.Parse(Console.ReadLine());
            Console.Write("Digite o salto: ");
            int s = int.Parse(Console.ReadLine());
            if (vi > vf)
            {
                while (vi >= vf)
                {
                    Console.Write($"{vi}.. ");
                    vi -= s;
                }
            }
            else if (vf > vi)
            {
                while (vi <= vf)
                {
                    Console.Write($"{vi}.. ");
                    vi += s;
                }
            }
        }
    }
}


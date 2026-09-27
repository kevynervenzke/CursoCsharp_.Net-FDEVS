using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace anobissexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ano Bissexto");
            Console.Write("Digite o ano que deseja saber: ");
            int ano = int.Parse(Console.ReadLine());
            if (ano % 4 == 0)
            {
                Console.WriteLine($"O ano {ano} é bissexto");
            }
            else
            {
                Console.WriteLine($"O ano {ano} não é bissexto");
            }
        }
    }
}

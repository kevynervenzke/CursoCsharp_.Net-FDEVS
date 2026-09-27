using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace somatorioflag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int flag = 0;
            do
            {
                Console.WriteLine("Somatório de Números com Flag");
                Console.Write("Digite um número: ");
                int n = int.Parse(Console.ReadLine());
                total += n;
                flag = int.Parse(Console.ReadLine());
                Console.Clear();
            } while (flag != 1111);
            Console.WriteLine($"A soma total dos valores é {total}");

        }
    }
}

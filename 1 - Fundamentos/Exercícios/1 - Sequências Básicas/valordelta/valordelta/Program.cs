using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace valordelta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Delta da Equação de Segundo Grau");
            Console.Write("Digite o valor de a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de c: ");
            int c = int.Parse(Console.ReadLine());
            double d = (Math.Pow(b, 2) - 4 * a * c);
            Console.WriteLine(d);
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace calculodetriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculando Triângulos");
            Console.Write("Digite o valor do 1º lado: ");
            int l1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor do 2º lado: ");
            int l2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor do 3º lado: ");
            int l3 = int.Parse(Console.ReadLine());
            if (l1 < (l2 + l3) && l2 < (l1 + l3) && l3 < (l1 + l2))
            {
                Console.WriteLine("O valor dos segmentos formam um triângulo");
                if (l1 == l2 && l2 == l3)
                {
                    Console.WriteLine("O triângulo é equilátero");
                }
                else if (l1 == l2 || l2 == l3)
                {
                    Console.WriteLine("O triângulo é isósceles");
                }
                else
                {
                    Console.WriteLine("O triângulo é escaleno");
                }
            }
            else
            {
                Console.WriteLine("O valor dos segmentos não formam um triângulo");
            }
        }
    }
}

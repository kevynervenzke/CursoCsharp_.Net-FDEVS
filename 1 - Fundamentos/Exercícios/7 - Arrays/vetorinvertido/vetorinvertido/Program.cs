using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetorinvertido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int[10];
            for (int i = 0; i < valores.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º valor: ");
                valores[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Valores Invertidos: ");
            for (int i = 9; i >= 0 ; i--)
            {
                Console.Write($"{valores[i]}..  ");
            }
        }
    }
}

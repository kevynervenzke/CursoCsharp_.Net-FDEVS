using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenciaFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("       Sequência de Fibonacci        ");
            Console.WriteLine("=====================================");
            int Valor0 = 0;
            int Valor1 = 1;
            Console.Write($"{Valor1} ");
            for (int contador = 1; contador <= 10; contador++)
            {
                
                int ValorS = Valor0 + Valor1;
                Valor0 = Valor1;
                Valor1 = ValorS;
                Console.Write($"{ValorS} ");
            }
            Console.WriteLine("\n=====================================");

        }
    }
}

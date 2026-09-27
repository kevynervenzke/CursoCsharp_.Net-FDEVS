using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advinhandonum4tentativas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int contador = 1;
            while (contador <= 4)
            {
                Console.WriteLine("Advinhe o número de 1 a 10 - 4 tentativas");
                Console.Write("Digite o número: ");
                int nj = int.Parse(Console.ReadLine());
                int npc = random.Next(1, 11);
                if (nj == npc)
                {
                    Console.WriteLine("Parabéns você acertou o número!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Você errou o número, o número correto era: " + npc);
                    Console.ReadKey();

                }
                Console.Clear();
                contador++;
            }
        }
    }
}


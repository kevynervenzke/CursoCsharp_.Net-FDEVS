using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetor30sorteado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int TotalPosições = 0;
            int[] NumerosSorteados = new int[29];
            int[] PosicaoChave = new int[29];
            Random rnd = new Random();
            Console.WriteLine("======================================");
            Console.WriteLine("            NÚMERO CHAVE              ");
            Console.WriteLine("======================================");
            Console.Write("Digite o número chave: ");
            int chave = int.Parse(Console.ReadLine());
            for (int i = 0; i < NumerosSorteados.Length; i++)
            {
                NumerosSorteados[i] = rnd.Next(1, 16);
                if (NumerosSorteados[i] == chave)
                {
                    TotalPosições++;
                    PosicaoChave[i] = i + 1;
                }
            }
            if (TotalPosições > 0)
            {
                Console.WriteLine("Posições em que a chave foi encontrada:");
                for (int j = 0; j < PosicaoChave.Length; j++)
                {
                    if (PosicaoChave[j] != 0)
                    {
                        Console.Write($"{PosicaoChave[j]}.. ");
                    }
                }
                Console.WriteLine($"\nA chave foi sorteada {TotalPosições} vezes");
            }
            else
            {
                Console.WriteLine($"A chave {chave} não foi sorteada");
            }
        }
    }
}

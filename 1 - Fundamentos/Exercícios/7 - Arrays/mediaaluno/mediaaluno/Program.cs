using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediaaluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float total = 0;
            Console.WriteLine("=================================");
            Console.WriteLine("Média de Notas");
            Console.WriteLine("=================================");
            float[] notas = new float[3];
            for(int i = 0; i < notas.Length; i++)
            {
                Console.Write($"Digite a {i + 1}ª nota: ");
                notas[i] = float.Parse(Console.ReadLine());
                total += notas[i];
            }
          float media = total/ notas.Length;
            for (int j = 0; j < notas.Length; j++)
            {
                Console.WriteLine($"Nota {j + 1}: {notas[j]}");
            }
            Console.WriteLine($"Média: {media}");
        }
    }
}

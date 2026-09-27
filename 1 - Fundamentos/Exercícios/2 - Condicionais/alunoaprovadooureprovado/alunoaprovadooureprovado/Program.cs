using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alunoaprovadooureprovado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aprovado ou Recuperação");
            Console.Write("Primeira Nota: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.Write("Segunda Nota: ");
            float n2 = float.Parse(Console.ReadLine());
            float m = (n1 + n2) / 2;
            if (m < 4.9f)
            {
                Console.WriteLine($"Média {m}: Reprovado!");
            }
            else if (m >= 5.0f && m < 6.9f)
            {
                Console.WriteLine($"Média {m}: Recuperação!");
            }
            else
            {
                Console.WriteLine($"Média {m}: Aprovado");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace alistamentomilitar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const int ano_atual = 2026;
            Console.WriteLine("Alistamento Militar");
            Console.Write("Ano de Nascimento: ");
            int ano_nasc = int.Parse(Console.ReadLine());
            int i = (ano_atual - ano_nasc);
            int tempo = 0;
            if (i < 18)
            {
                tempo = (18 - i);
                Console.WriteLine($"Faltam {tempo} anos para seu alistamento");
            }
            else
            {
                tempo = (i - 18);
                Console.WriteLine($"Já se passaram {tempo} anos do seu alistamento");
            }
        }
    }
}

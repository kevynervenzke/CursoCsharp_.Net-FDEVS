using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace titulo_eleitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int ano_atual = 2026;
            Console.WriteLine("Título de Eleitor");
            Console.Write("Em que ano você nasceu: ");
            int ano_nasc = int.Parse(Console.ReadLine());
            int i = (ano_atual - ano_nasc);
            if (i < 16)
            {
                Console.WriteLine($"Sua idade é {i} e você não pode votar!");
            }
            else if (i <= 16 && i < 18)
            {
                Console.WriteLine($"Sua idade é {i} e seu voto é facultativo.");
            }
            else if (i >= 18 && i < 70)
            {
                Console.WriteLine($"Sua idade é {i} e seu voto é obrigatório!");
            }
            else
            {
                Console.WriteLine($"Sua idade é {i} e seu voto é facultativo.");
            }

        }
    }
}


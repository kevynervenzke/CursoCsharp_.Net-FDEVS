using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jokenpo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Jokenpô");
            Console.WriteLine("Pedra - 1");
            Console.WriteLine("Papel - 2");
            Console.WriteLine("Tesoura - 3");
            Console.Write("Digite sua Escolha: ");
            int nj = int.Parse(Console.ReadLine());
            int npc = random.Next(1, 4);
            if (nj == npc)
            {
                Console.WriteLine($"Você escolheu {nj}\nO Computador escolheu {npc}\nEmpate!");
            }
            else if (nj == 1 && npc == 2)
            {
                Console.WriteLine($"Você escolheu {nj}\nO Computador escolheu {npc}\nVocê Perdeu!");
            }
            else if (nj == 2 && npc == 1)
            {
                Console.WriteLine($"Você escolheu {nj}\nO Computador escolheu {npc}\nVocê Venceu!");
            }
            else if (nj == 3 && npc == 1)
            {
                Console.WriteLine($"Você escolheu {nj}\nO Computador escolheu {npc}\nVocê Perdeu!");
            }
            else if (npc == 1 && nj == 2)
            {
                Console.WriteLine($"Você escolheu {nj}\nO Computador escolheu {npc}\nVocê Ganhou!");
            }
            else if (npc == 2 && nj == 1)
            {
                Console.WriteLine($"Você escolheu {nj}\nO Computador escolheu {npc}\nVocê Perdeu!");
            }
            else if (npc == 3 && nj == 2)
            {
                Console.WriteLine($"Você escolheu {nj}\nO Computador escolheu {npc}\nVocê Perdeu!");
            }
            else if (npc == 3 && nj == 1)
                Console.WriteLine($"Você escolheu {nj}\nO Computador escolheu {npc}\nVocê Ganhou!");
        }
    }
}


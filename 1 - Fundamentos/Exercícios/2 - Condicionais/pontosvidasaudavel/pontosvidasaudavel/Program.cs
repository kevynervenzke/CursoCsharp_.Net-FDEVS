using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace pontosvidasaudavel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa de Pontos Vida-Saudável");
            Console.Write("Quantas horas de atividade fez esse mês: ");
            float h = float.Parse(Console.ReadLine());
            if (h < 10)
            {
                float ponto = 2 * h;
                float d = ponto * 0.05f;
                Console.WriteLine($"Você fez {h} de atividade físicas esse mês\nGanhou {ponto} pontos\nE ganhou {d:F2}R$");
            }
            else if (h >= 10 && h < 20)
            {
                float ponto = 5 * h;
                float d = ponto * 0.05f;
                Console.WriteLine($"Você fez {h} de atividade físicas esse mês\nGanhou {ponto} pontos\nE ganhou {d:F2}R$");
            }
            else
            {
                float ponto = 10 * h;
                float d = ponto * 0.05f;
                Console.WriteLine($"Você fez {h} de atividade físicas esse mês\nGanhou {ponto} pontos\nE ganhou {d:F2}R$");
            }
        }
    }
}

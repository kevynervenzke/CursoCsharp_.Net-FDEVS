using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idade_e_Media
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fim = 999;
            float TotAlunos = 0;
            float TotIdade = 0;
            float media = 0;
            do
            {
                int contador = 1;
                Console.WriteLine("Quantidade de Alunos e Média de Idade");
                Console.Write("Quantos alunos tem na turma: ");
                TotAlunos = float.Parse(Console.ReadLine());
                while (contador <= TotAlunos)
                {
                    Console.Write($"Nome do {contador}º aluno: ");
                    string nome = Console.ReadLine();
                    Console.Write($"Qual a idade de {nome}: ");
                    float idade = float.Parse(Console.ReadLine());
                    TotIdade += idade;
                    contador++;
                }
                Console.Write("Quer Corrigir o Programa?: ");
                fim = int.Parse(Console.ReadLine());
            } while (fim != 999);
            media = TotIdade / TotAlunos;
            Console.WriteLine($"Tem {TotAlunos} alunos na turma e a média de idade é {media:F2} anos");
        }
    }
}

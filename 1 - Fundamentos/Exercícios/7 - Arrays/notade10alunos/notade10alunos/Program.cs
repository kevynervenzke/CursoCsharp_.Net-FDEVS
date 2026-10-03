using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notade10alunos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] Notas = new float[10];
            string[] Alunos = new string[10];
            float[] MaiorNotas = new float[10];
            string[] MaiorAlunos = new string[10];
            float TotalNotas = 0;
            float MaiorNota = 0;
            int PosMaiorNota = 0;
            string MaiorAluno = "";
            float Media = 0;
            int AlunoMaior_Media = 0;
            Console.WriteLine("===================================");
            Console.WriteLine("         CADASTRO DE ALUNOS        ");
            Console.WriteLine("===================================");
            for(int contador = 0; contador < Notas.Length; contador++)
            {
                Console.Write($"Nome do {contador + 1}º Aluno: ");
                Alunos[contador] = Console.ReadLine();
                Console.Write($"Nota de {Alunos[contador]}: ");
                Notas[contador] = float.Parse(Console.ReadLine());
                Console.Clear();
                TotalNotas += Notas[contador];
                if (Notas[contador] > MaiorNota)
                {
                    MaiorNota = Notas[contador];
                    PosMaiorNota = contador + 1;
                    MaiorAluno = Alunos[contador];
                }
            }
            Media = TotalNotas / Alunos.Length;
            for (int i = 0; i < Notas.Length; i++)
            {
                if (Notas[i] > Media)
                {
                    AlunoMaior_Media++;
                    MaiorAlunos[i] = Alunos[i];
                    MaiorNotas[i] = Notas[i];
                }
            }
            Console.WriteLine("===================================");
            Console.WriteLine($"         MÉDIA DA TURMA: {Media:F2}        ");
            Console.WriteLine("===================================");
            Console.WriteLine($"{AlunoMaior_Media} Alunos estão acima da média");
            Console.WriteLine($"A maior nota foi de {MaiorAluno} que tirou {MaiorNota:F2} e está na {PosMaiorNota}ª posição");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaalunos
{
    internal class Program
    {
        static void cabecalho() 
        {
            Console.WriteLine("======================================");
            Console.WriteLine("          Cadastro de Alunos");
            Console.WriteLine("======================================");
        }
        static void Main(string[] args)
        {
            int posicao = 1;
                
            string[] alunos = new string[10];
                
                for (int i = 0;i < alunos.Length; i++)
                {
                
                cabecalho();
                Console.Write($"Digite o nome do aluno: ");
                string nome = Console.ReadLine();
                Console.Write($"Qual vai ser a posição dele? ");
                posicao = int.Parse(Console.ReadLine());
                posicao -= 1;
                alunos[posicao] = nome;
                Console.Clear();
            }
            while (true == true)
            {
                cabecalho();
                Console.Write("Digite o número do Aluno que deseja saber: ");
                int posicao2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"Posição {posicao2}: {alunos[posicao2 - 1]}"); 
            }
        }
    }
}

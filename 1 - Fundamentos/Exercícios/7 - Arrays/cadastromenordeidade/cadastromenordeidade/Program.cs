using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastromenordeidade
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string[] Nomes = new string[9];
            string[] NomesMenor = new string[9];
            int[] Idades = new int[9];
            int[] IdadesMenor = new int[9];
            int[] PosMenor = new int[9];
            Console.WriteLine("======================================");
            Console.WriteLine("          Cadastro de Pessoas         ");
            Console.WriteLine("======================================");
            for(int i = 0; i < Nomes.Length; i++)
            {
                Console.Write($"Nome da {i + 1}ª Pessoa: ");
                Nomes[i] = Console.ReadLine();
                Console.Write($"Idade da {i + 1}ª Pessoa: ");
                Idades[i] = int.Parse(Console.ReadLine());
                Console.Clear();
                if (Idades[i] < 18)
                {
                    NomesMenor[i] = Nomes[i];
                    IdadesMenor[i] = Idades[i];
                    PosMenor[i] = i;
                }
            }
            Console.WriteLine();
            Console.WriteLine("======================================");
            Console.WriteLine("        LISTA TOTAL DE PESSOAS        ");
            Console.WriteLine("======================================");
            for(int j = 0; j< Nomes.Length; j++)
            {
                Console.WriteLine($"{j + 1}ª Pessoa: ");
                Console.WriteLine($"Nome: {Nomes[j]}");
                Console.WriteLine($"Idade: {Idades[j]}");
                Console.WriteLine("======================================");
            }
            Console.WriteLine();
            Console.WriteLine("======================================");
            Console.WriteLine("        PESSOAS MENOR DE IDADE        ");
            Console.WriteLine("======================================");
            for(int c = 0; c < NomesMenor.Length; c++)
            {
                if (IdadesMenor[c] != 0)
                {
                    Console.WriteLine($"{c + 1}ª Pessoa: ");
                    Console.WriteLine($"Nome: {NomesMenor[c]}");
                    Console.WriteLine($"Idade: {IdadesMenor[c]}");
                    Console.WriteLine("======================================");
                }
            }
        }
    }
}

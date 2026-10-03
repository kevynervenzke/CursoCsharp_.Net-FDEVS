using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace analisadorfuncionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Nomes = new string[5];
            string[] Sexo = new string[5];
            float[] Salario = new float[5];
            string[] Nome5mil = new string[5];
            string[] Sexo5mil = new string[5];
            float[] Salario5mil = new float[5];
            Console.WriteLine("============================================");
            Console.WriteLine("         Analisador de Funcionários         ");
            Console.WriteLine("============================================");
            for(int i = 0; i < Nomes.Length; i++)
            {
                Console.Write($"Nome do {i + 1}º Funcionário: ");
                Nomes[i] = Console.ReadLine();
                do
                {
                    Console.Write($"Sexo de {Nomes[i]} [M/F]: ");
                    Sexo[i] = Console.ReadLine().ToLower();
                } while (Sexo[i] != "m" && Sexo[i] != "f");
                Console.Write($"Salário do {Nomes[i]} [R$]: ");
                Salario[i] = float.Parse(Console.ReadLine());
                if (Sexo[i] == "f" && Salario[i] > 5000)
                {
                    Nome5mil[i] = Nomes[i];
                    Sexo5mil[i] = Sexo[i];
                    Salario5mil[i] = Salario[i];
                }
                Console.Clear();
            }
            Console.WriteLine();
            Console.WriteLine("============================================");
            Console.WriteLine("                LISTA TOTAL                 ");
            Console.WriteLine("============================================");
            for(int j = 0; j< Nomes.Length; j++)
            {
                Console.WriteLine($"{j + 1}º Funcionário:");
                Console.WriteLine($"Nome: {Nomes[j]}");
                Console.WriteLine($"Sexo: {Sexo[j]}");
                Console.WriteLine($"Salário: {Salario[j]:F2}R$");
                Console.WriteLine("============================================");
            }
            Console.WriteLine();
            Console.WriteLine("============================================");
            Console.WriteLine(" LISTA DE MULHEROS QUE GANHAM MAIS DE 5 MIL ");
            Console.WriteLine("============================================");
            for (int c = 0; c < Nome5mil.Length; c++)
            {
                if (Salario5mil[c] != 0)
                {
                    Console.WriteLine($"{c + 1}º Funcionário:");
                    Console.WriteLine($"Nome: {Nomes[c]}");
                    Console.WriteLine($"Sexo: {Sexo[c]}");
                    Console.WriteLine($"Salário: {Salario[c]:F2}R$");
                    Console.WriteLine("============================================");
                }
            }
        }
    }
}

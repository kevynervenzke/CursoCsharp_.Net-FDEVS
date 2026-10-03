using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nome7pessoasinverso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[7];
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º nome: ");
                nomes[i] = Console.ReadLine();
                Console.Clear();
            }
            Console.WriteLine();
            Console.WriteLine("Ordem Normal: ");
            for (int j = 0; j< nomes.Length; j++)
            {
                Console.WriteLine($"{j + 1}º Nome: {nomes[j]}");
            }
            Console.WriteLine("Ordem Inversa: ");
            for (int contador = 6; contador >= 0; contador--)
            {
                Console.WriteLine($"{contador + 1}º Nome: {nomes[contador]}");
            }
        }
    }
}

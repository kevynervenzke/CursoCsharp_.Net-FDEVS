using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenciaFibonacci
{
    internal class Program
    {
        static int menu()
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("       Sequência de Fibonacci        ");
            Console.WriteLine("=====================================");
            Console.Write("Deseja quantos números da sequência? ");
            int NumSequencia = int.Parse(Console.ReadLine());
            Console.WriteLine("=====================================");
            NumSequencia--;
            return NumSequencia;
        }
        static void Main(string[] args)
        {
            string resp = "s";
            do
            {
                int NumSequencia = menu();
                int Valor0 = 0;
                int Valor1 = 1;
                Console.Write($"{Valor1} ");
                for (int contador = 1; contador <= NumSequencia; contador++)
                {

                    int ValorS = Valor0 + Valor1;
                    Valor0 = Valor1;
                    Valor1 = ValorS;
                    Console.Write($"{ValorS} ");
                }
                Console.WriteLine("\n=====================================");
                Console.Write("Deseja Continuar? [S/N]: ");
                resp = Console.ReadLine().ToLower();
                Console.Clear();
                if (resp == "n")
                {
                    Console.WriteLine("=====================================");
                    Console.WriteLine("       Sequência de Fibonacci        ");
                    Console.WriteLine("=====================================");
                    Console.Write("Aperte qualquer tecla para fechar o programa: ");
                    Console.WriteLine("\n=====================================");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                if (resp != "s" && resp != "n")
                {
                    Console.WriteLine("=====================================");
                    Console.WriteLine("       Sequência de Fibonacci        ");
                    Console.WriteLine("=====================================");
                    Console.WriteLine("         Resposta Inválida           ");
                    Console.Write("Aperte qualquer tecla para fechar o programa: ");
                    Console.WriteLine("\n=====================================");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            } while (resp == "s");
            
        }
    }
}
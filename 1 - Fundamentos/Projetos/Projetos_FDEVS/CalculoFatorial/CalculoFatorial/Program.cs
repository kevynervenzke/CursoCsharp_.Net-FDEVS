using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoFatorial
{
    internal class Program
    {
        static int Menu()
        {
            Console.Clear();
            Console.WriteLine("=============================");
            Console.WriteLine("      CÁLCULO FATORIAL       ");
            Console.WriteLine("=============================");
            Console.Write("Digite o número que deseja saber o fatorial: ");
            int Num = int.Parse(Console.ReadLine());
            Console.WriteLine("=============================");
            int Produto = (Num * (Num - 1));
            for (int Contador = Num - 2; Contador >= 2; Contador--)
            {
                Produto = (Produto * Contador);

            }
            Console.Write($"{Num}! = ");
            for (int Contador2 = Num; Contador2 >= 1; Contador2--)
            {
                if (Contador2 == 1)
                {
                    Console.Write($"1 = ");
                }
                else
                {
                    Console.Write($"{Contador2} x ");
                }
            }
            Console.WriteLine(Produto);
            return Produto;


        }
        static void Main(string[] args)
        {
            string resp = "s";
            while (resp == "s")
            {
                int Produto_main = Menu();
                Console.WriteLine("=============================");
                Console.Write("Deseja Continuar? [S/N] ");
                resp = Console.ReadLine().ToLower();
                Console.WriteLine("=============================");
                if (resp == "n")
                {
                    Console.Write("Digite qualquer Tecla para sair do programa");
                    Console.WriteLine("\n=============================");
                    Console.ReadKey();
                    Environment.Exit(0);
                }

                while (resp != "s" && resp != "n")
                {
                    Console.Clear();
                    Console.WriteLine("=============================");
                    Console.WriteLine("Resposta Inválida!");
                    Console.WriteLine("\n=============================");
                    Console.Write("Deseja Continuar? [S/N] ");
                    resp = Console.ReadLine().ToLower();
                    if (resp == "s")
                    {
                        Menu();
                    }
                    else if (resp == "n")
                    {
                        Console.WriteLine("\n=============================");
                        Console.Write("Digite qualquer Tecla para sair do programa");
                        Console.WriteLine("\n=============================");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                }


            }
        }
    }
}


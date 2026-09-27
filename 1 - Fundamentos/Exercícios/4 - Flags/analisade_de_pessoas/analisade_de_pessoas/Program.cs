using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace analisade_de_pessoas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resp = "s";
            int contador = 1;
            float qtd_pessoas = 0;
            float MaiorI = 0;
            float numero_homens = 0;
            float MenorMI = 0;
            float MediaH = 0;
            float idade_homens = 0;

            Console.WriteLine("Analisador de Pessoas");
            do
            {
                Console.Write("Quantidade de Pessoas: ");
                qtd_pessoas = float.Parse(Console.ReadLine());
                while(contador <= qtd_pessoas || contador == qtd_pessoas)
                {
                    Console.Write($"Qual o sexo da {contador}ª pessoa: ");
                    string sexo = Console.ReadLine().ToLower();
                    if (sexo.ToLower() != "m" && sexo.ToLower() != "f")
                    {
                        Console.WriteLine("Sexo Inválido!");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                    Console.Write($"Qual a idade da {contador}ª pessoa: ");
                    float idade = float.Parse(Console.ReadLine());
                    Console.Clear();
                    if (idade > MaiorI)
                    {
                        MaiorI += idade;
                    }
                    if (sexo == "m")
                    {
                        idade_homens += idade;
                        numero_homens += 1;
                    }
                    if ((sexo == "f" && idade < MenorMI) && MenorMI == 0)
                    {
                        MenorMI = idade;
                    }
                    
                    contador++;
                }
                contador = 1;
                qtd_pessoas = 0;
                MediaH = idade_homens / numero_homens;

                Console.Write("Deseja Restaurar o Programa: [S/N]: ");
                resp = Console.ReadLine().ToLower();
                if (resp.ToLower() == "n")
                {
                    Console.WriteLine("Fim do Programa!");
                }
                if (resp.ToLower() != "n" && resp.ToLower()!= "s")
                {
                    Console.WriteLine("Resposta Inválida!");
                }
            } while (resp.ToLower() == "s");
            Console.WriteLine($"A maior idade lida é {MaiorI} anos");
            Console.WriteLine($"Quantidade de homens cadastrados: {numero_homens}");
            Console.WriteLine($"A idade da mulher mais jovem é {MenorMI} anos");
            Console.WriteLine($"A média de idade dos homens é {MediaH:F2} anos");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace analisador_de_pessoas2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float MaiorI = 0;
            string MaiorNome = "";
            string MenorNome = "";
            float MenorIM = 0;
            float Homem_30 = 0;
            float Mulher_18 = 0;
            float TotalI = 0;
            float TotalP = 0;
            string resp = "s";
            float media = 0;
            Console.WriteLine("Cadastro de Pessoas");
            do
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Idade: ");
                float idade = float.Parse(Console.ReadLine());
                Console.Write("Sexo [M/F]: ");
                string sexo = Console.ReadLine().ToLower();
                if (sexo.ToLower() != "m" && sexo.ToLower() != "f")
                {
                    Console.WriteLine("Sexo Inválido!");
                }
                TotalI += idade;
                TotalP++;
                if (idade > MaiorI)
                {
                    MaiorI = idade;
                    MaiorNome = nome;
                }
                if ((sexo.ToLower() == "f" || idade <= MenorIM) && MenorIM == 0)
                {
                    MenorIM = idade;
                    MenorNome = nome;
                }
                if (sexo.ToLower() == "m" && idade > 30)
                {
                    Homem_30++;
                }
                if (sexo.ToLower() == "f" && idade < 18)
                {
                    Mulher_18++;
                }

                Console.Write("Deseja Continuar [S/N]");
                resp = Console.ReadLine().ToLower();
                if (resp.ToLower() == "n")
                {
                    Console.WriteLine("Fim do Programa!");
                }
                else if (resp.ToLower() != "n" && resp.ToLower() != "s")
                {
                    Console.WriteLine("Resposta Inválida!");
                }
                Console.Clear();
            } while (resp.ToLower() == "s");
            media = TotalI / TotalP;
            Console.WriteLine($"A pessoa mais velha é {MaiorNome} com {MaiorI} anos");
            Console.WriteLine($"A mulher mais jovem do grupo é {MenorNome} com {MenorIM} anos");
            Console.WriteLine($"A média de idade do grupo é {media:F2} anos");
            Console.WriteLine($"Quantidade de Homens com mais de 30 anos: {Homem_30}");
            Console.WriteLine($"Quantidade de Mulheres com menos de 18 anos: {Mulher_18}");
        }
    }
}

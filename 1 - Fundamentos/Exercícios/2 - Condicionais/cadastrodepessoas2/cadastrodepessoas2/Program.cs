using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastrodepessoas2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Analisador de Pessoas 2.0");
            int contador = 1;
            int TotMI = 0;
            int TotFI = 0;
            int TotM = 0;
            int TotF = 0;
            int Tot20 = 0;
            while (contador <= 5)
            {
                Console.Write("Qual seu Sexo: [M/F]");
                string sexo = Console.ReadLine();
                Console.Write("Qual sua Idade: ");
                int idade = int.Parse(Console.ReadLine());
                if (sexo == "M" || sexo == "m")
                {
                    TotM++;
                    TotMI += idade;
                }
                if (sexo == "F" || sexo == "f")
                {
                    TotF++;
                    TotFI += idade;
                }
                else if (TotFI > 20)
                {
                    Tot20++;
                }
                contador++;
            }
            float MediaM = TotMI / TotM;
            float MediaTotal = (TotMI + TotFI) / (TotM + TotF);
            Console.WriteLine($"Total de pessoas do sexo masculino: {TotM}");
            Console.WriteLine($"Total de pessoas do sexo feminino: {TotF}");
            Console.WriteLine($"Total de mulheres com mais de 20 anos: {Tot20}");
            Console.WriteLine($"Média de idade do sexo masculino: {MediaM}");
            Console.WriteLine($"Média de idade total: {MediaTotal}");
        }
    }
}

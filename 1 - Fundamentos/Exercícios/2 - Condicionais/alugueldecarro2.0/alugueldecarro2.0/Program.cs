using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace alugueldecarro2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aluguel de Carros");
            Console.WriteLine("Carro Popular R$90,00/dia [1]");
            Console.WriteLine("Carro de Luxo R$150,00/dia [2]");
            Console.Write("Escolha seu carro: ");
            int carro = int.Parse(Console.ReadLine());
            Console.Write("Quantos dias ficou com o carro: ");
            float dias = float.Parse(Console.ReadLine());
            Console.Write("Quantos Km foram percorridos: ");
            float km = float.Parse(Console.ReadLine());
            if (carro == 1 && km < 100)
            {
                float valor = ((90 * dias) + (0.20f * km));
                Console.WriteLine($"Você escolheu Carro Popular, alugou por {dias} dias e andou {km}Km.\nO valor a ser pago será de R${valor:F2}");
            }
            else if (carro == 1 && km >= 100)
            {
                float valor = ((90 * dias) + (0.10f * km));
                Console.WriteLine($"Você escolheu Carro Popular, alugou por {dias} dias e andou {km}Km.\nO valor a ser pago será de R${valor:F2}");
            }
            if (carro == 2 && km < 200)
            {
                float valor = ((150 * dias) + (0.30f * km));
                Console.WriteLine($"Você escolheu Carro de Luxo, alugou por {dias} dias e andou {km}Km.\nO valor a ser pago será de R${valor:F2}");
            }
            else if (carro == 2 && km >= 200)
            {
                float valor = ((150 * dias) + (0.25f * km));
                Console.WriteLine($"Você escolheu Carro Popular, alugou por {dias} dias e andou {km}Km.\nO valor a ser pago será de R${valor:F2}");
            }

        }
    }
}

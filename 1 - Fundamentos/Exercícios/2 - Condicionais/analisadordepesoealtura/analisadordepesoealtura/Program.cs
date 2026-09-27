using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisadordePesoeAltura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Analisador de Altura e Peso");
            int contador = 1;
            float Peso90 = 0;
            float peso50 = 0;
            float peso100 = 0;
            float totalAltura = 0;
            while (contador <= 7)
            {
                Console.Write("Digite seu Peso (kg): ");
                float peso = float.Parse(Console.ReadLine());
                Console.Write("Digite sua Altura (m): ");
                float altura = float.Parse(Console.ReadLine());
                totalAltura += altura;
                if (peso > 90)
                {
                    Peso90++;
                }
                if (peso < 50 && altura < 1.60f)
                {
                    peso50++;
                }
                if (peso > 100 && altura > 1.90f)
                {
                    peso100++;
                }
                contador++;
            }
            float mediaAltura = totalAltura / 7;
            Console.WriteLine($"Pessoas com peso superior a 90kg: {Peso90}");
            Console.WriteLine($"Pessoas com peso inferior a 50kg e altura inferior a 1,60m: {peso50}");
            Console.WriteLine($"Pessoas com peso superior a 100kg e altura superior a 1,90m: {peso100}");
            Console.WriteLine($"Média de altura das pessoas: {mediaAltura:F2}m");
        }
    }
}

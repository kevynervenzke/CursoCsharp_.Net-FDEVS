using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float Total = 0;
            float TotalMenor = 0;
            Random rnd = new Random();
            int[] numeros = new int[50];
            Console.WriteLine("=============================================");
            Console.WriteLine("             Lendo 50 números");
            Console.WriteLine("=============================================");
            for (int i = 0; i < numeros.Length; i++) 
            {
                numeros[i] = rnd.Next(1, 51);
                Total += numeros[i];
                
            }
            float media = Total / numeros.Length;
            Console.WriteLine($"Média dos Números: {media}");
            Console.WriteLine($"Números abaixo da média: ");
            for (int i =0; i < numeros.Length; i++)
            {
                if (numeros[i] < media)
                {
                    Console.Write($"{numeros[i]}  ");
                    TotalMenor += 1;
                }
            }

            Console.WriteLine($"\nTotal de Números abaixo da média: {TotalMenor}");
        }
    }
}

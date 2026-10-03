using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome1 = "Ana Silva";
            string nome2 = "José Martins";
            string nome3 = "Afonso Teixeira";
            string nome4 = "Maria Gomes";
            string nome5 = "Sofia Costa"; 

            Console.WriteLine("=================================");
            Console.WriteLine($"Nomes 1: {nome1}");
            Console.WriteLine($"Nomes 2: {nome2}");
            Console.WriteLine($"Nomes 3: {nome3}");
            Console.WriteLine($"Nomes 4: {nome4}");
            Console.WriteLine($"Nomes 5: {nome5}");
            Console.WriteLine("=================================");

            //1ª forma de declarar um array
            string[] nomes = new string[]{"Ana", "José", "Afonso", "Maria" };


            //2ª forma de declarar um array
            //Cria um array de 4 posições
            string[] sobrenomes = new string[5];
            sobrenomes[0] = "Silva";
            sobrenomes[1] = "Martins";
            sobrenomes[2] = "Teixeira";
            sobrenomes[3] = "Gomes";
            sobrenomes[4] = "Costa";

           /* for (int contador = 0; contador < nomes.Length; contador++) 
            {
                Console.WriteLine($"Nome {contador + 1}: {nomes[contador]} {sobrenomes[contador]}");
            }
            Random rnd = new Random();
            int[] numeros = new int[50];
            for (int contador = 0; contador < numeros.Length; contador++)
            {
                numeros[contador] = rnd.Next(1, 100);
                Console.Write($"{numeros[contador]}   ");
            }

            double[] decimais = new double[10];
            bool[] booleanos = new bool[10];
           */

            int[,] tabuada = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    tabuada[i, j] = (i + 1) * (j + 1);
                    Console.Write(tabuada[i, j] + " \t");   
                }
                Console.WriteLine();
            }
        }
    }
}

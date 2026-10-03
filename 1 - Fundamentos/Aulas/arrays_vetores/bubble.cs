using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace bubblesort
{
    internal class Program
    {
        static int[] numeros;
        static void Main(string[] args)
        {
            Random rnd = new Random();
            numeros = new int[10];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = rnd.Next(1, 100);
            }
            Console.WriteLine("========== ORDEM INICIAL ============");


            Console.WriteLine("========== ORDEM CRESCENTE ============");
            Array.Sort(numeros);



            Console.WriteLine("========== ORDEM DECRESCENTE ============");

        }

    }
}
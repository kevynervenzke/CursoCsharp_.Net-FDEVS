using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroQualquer = 20 + 20;
            int numeroMult = 10 * 10;
            float numeroDiv = 5.0f / 2; // ele vai pegar só a parte inteira da divisão
            int teste = 2 + 2 * 10;
            Console.WriteLine(numeroQualquer);
            Console.WriteLine(numeroMult);
            Console.WriteLine(numeroDiv);
            Console.WriteLine(teste);

            // 6/2 = 3
            // 5/2 = 2.5 -> float

            Console.ReadLine();
        }
    }
}

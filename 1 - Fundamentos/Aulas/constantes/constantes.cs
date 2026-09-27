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
            
            Console.Write("Escreva seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Seu nome é: ");
            Console.Write(nome);


            Console.ReadLine();
        }
    }
}

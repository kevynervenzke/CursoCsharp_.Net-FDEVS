using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tem que estar dentro da class
            //Útil para executar várias vezes sem ficar copiando e colando
            //Parâmetros usados dentro da função só funciona dentro da função
            //A variável interna da função só funciona dentro dela

            //GerarPreco(-200);

            string valor = Console.ReadLine();
            Console.WriteLine(valor);
            
            Console.ReadLine();
        }

        static void ExibirMsg()
        {
            Console.WriteLine("Esse sistema é show de bola!");
            Console.WriteLine("Estou usando funções");
            Console.WriteLine("Bem vindo!");
            Console.WriteLine("Guia do Programador");
            Console.WriteLine("Kevyner Ramalho");
        }
        
        static void GerarPreco(int preco)
        {
            int precoAbs = Math.Abs(preco);
            int valorFinal = precoAbs + (2 * precoAbs);
            Console.WriteLine($"O preço final é: {valorFinal}");
        }




    }
}

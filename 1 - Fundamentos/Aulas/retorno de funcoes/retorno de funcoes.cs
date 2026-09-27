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
            //Como retornar resultado de funções
            //A informação que passa antes do nome da função que define o retorno
            //Exemplo: void -> não retorna nada
            //Tipos de retorno: int, string, bool, double, float, decimal, char, object
            //O tipo de retorno da função tem que ser igual a da função
            //O retorno serve para retornar valores e variáveis que funcionam só dentro da função
            // Pra isso no corpo principal tem que criar uma variável que recebe a atribuição da função
            // Tudo que está abaixo do return não é executado, pois o return encerra a função

            int soma1 = Somar(1, 2, 3);
            int soma2 = Somar(4, 5, 6);
            int soma3 = Somar(7, 8, 9);

            Console.WriteLine(soma1);
            Console.WriteLine(soma2);
            Console.WriteLine(soma3);
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

        static int Somar(int a, int b, int c)
        {
            int resultadoFinal = a + b + c;
            return resultadoFinal;

            Console.WriteLine("A");
        }


    }
}

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
            //switch (variavel) case condicao: break;
            //não pode trabalhar com operadores lógicos, comparacionais

            string cor = "Verde";


            switch (cor)
            {
                case "Vermelho":
                    Console.WriteLine("Sua cor favorita é vermelho!");
                    break;

                case "Amarelo":
                    Console.WriteLine("Sua cor favorita é amarelo!");
                    break;
                case "Azul":
                    Console.WriteLine("Sua cor favorita é azul!");
                    break;
                default:
                    Console.WriteLine("Sua cor favorita eu não sei!");
                    break;
            }
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

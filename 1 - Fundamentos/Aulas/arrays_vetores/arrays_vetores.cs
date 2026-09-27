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
            //Vetores/arrays -> servem para armazenar vários dados/variáveis em uma lista
            //Definir o tipo do array ex:"string[] produtos = new string[Tamanho do array] {itens do array}" com o nome no final
            //Não pode mudar o tamanho do array
            //Cada item tem um índice que começa do 0 ex.: produtos[0]



            string produto1 = "Sea of Thieves";//0
            string produto2 = "FIFA";//1
            string produto3 = "Half-life";//2
            string produto4 = "Minecraft";//3
            string produto5 = "Portal";//4
            string produto6 = "CS";//5


            string[] produtos = new string[5] { "Sea of thieves", "FIFA", "Minecraft", "Half-life", "Portal" };

            produtos[1] = "FIFA 2027";

            int[] valores = {40, 50, 60, 70, 20};

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

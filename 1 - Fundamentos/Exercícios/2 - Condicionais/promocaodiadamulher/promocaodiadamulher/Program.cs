using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace promocaodiadamulher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Promoção Dia da Mulher");
            Console.Write("Digite seu Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Qual seu Sexo [M/F]: ");
            string sexo = Console.ReadLine();
            Console.Write("Qual o valor da Compra: ");
            float valor = float.Parse(Console.ReadLine());
            if (sexo == "F" || sexo == "f")
            {
                float desconto = (valor - (valor * 13) / 100);
                Console.WriteLine($"A cliente {nome} ganhou 13% de desconto e sua compra de {valor} passou a valer {desconto:F2}!");
            }
            else
            {
                float desconto = (valor - (valor * 5) / 100);
                Console.WriteLine($"O cliente {nome} ganhou 5% de desconto e sua compra de {valor} passou a valer {desconto:F2}!");
            }
        }
    }
}
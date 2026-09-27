using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emprestimocasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Empréstimo de Casa");
            Console.Write("Valor da Casa [R$]: ");
            float valor_casa = float.Parse(Console.ReadLine());
            Console.Write("Salário do Comprador [R$]: ");
            float sal = float.Parse(Console.ReadLine());
            Console.Write("Em quantos anos vai pagar: ");
            float ano = float.Parse(Console.ReadLine());
            float prest_mensal = valor_casa / ano;
            if (prest_mensal > (sal * 30) / 100)
            {
                Console.WriteLine($"Empréstimo Negado!\nO valor da prestação é de {prest_mensal:F2}, sendo maior que 30% do salário.");
            }
            else
            {
                Console.WriteLine($"Empréstimo Aceito!\nO valor da prestação não excede 30% do salário.");
            }
        }
    }
}


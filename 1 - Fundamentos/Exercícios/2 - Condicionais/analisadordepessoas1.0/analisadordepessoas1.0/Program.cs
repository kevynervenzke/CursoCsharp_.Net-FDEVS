using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace analisadordepessoas1._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Analisador de Pessoas 1.0");
            int contador = 1;
            float TotI = 0;
            float Tot18 = 0;
            float Tot5 = 0;
            float TotM = 0;
            string nomeMaiorIdade = "";
            while (contador <= 10)
            {
                Console.Write($"Qual o nome da {contador}ª pessoa: ");
                string nome = Console.ReadLine();
                Console.Write($"Qual a idade do/da {nome}: ");
                float idade = float.Parse(Console.ReadLine());
                TotI += idade;
                if (idade > 18)
                {
                    Tot18++;
                }
                if (idade < 5)
                {
                    Tot5++;
                }
                if (idade > TotM)
                {
                    TotM = idade;
                    nomeMaiorIdade = nome;
                }
                contador++;
            }
            float media = TotI / 10;
            Console.WriteLine($"A média das idades é: {media:F2}");
            Console.WriteLine($"O número de pessoas com mais de 18 anos é: {Tot18:F0}");
            Console.WriteLine($"O número de pessoas com menos de 5 anos é: {Tot5:F0}");
            Console.WriteLine($"A maior idade é de {nomeMaiorIdade}: {TotM:F0} Anos");

        }
    }
}

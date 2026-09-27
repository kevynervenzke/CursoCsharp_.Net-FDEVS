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
            /*
            Tipos de Variáveis
            Int -156 como  32344
            Float = número real 3.53f (f no final) --> Double \ Decimal
            Bool - tipo lógico(True/False)
            String - "caracteres" - texto
            Char - caractere 'a' -> único caractere

            A-Z
            0-9
            *@#
             _
            não pode ter nome reservado

            */

            /*
            int SegundaGuerraMundial = 1942;
            string corFavorita = "Azul";
            float velocidadeF1 = 294.48f;
            bool segundaGuerraMundialAconteceu = true;

            Console.WriteLine(SegundaGuerraMundial);
            Console.WriteLine(corFavorita);
            Console.WriteLine(velocidadeF1);
            Console.WriteLine(segundaGuerraMundialAconteceu);

            velocidadeF1 = 348.29f;
            corFavorita = "Roxo";

            Console.WriteLine(velocidadeF1);
            Console.WriteLine(corFavorita);

            Console.ReadLine();
            */
            /*
            var cor_favorita = "Vermelho";
            var modeloDoProduto = 2323;


            
            */
            dynamic cor_favorita = "Vermelho";

            Console.WriteLine(cor_favorita);

            cor_favorita = 1234;

            Console.WriteLine(cor_favorita);

            cor_favorita = 22.34f;

            Console.WriteLine(cor_favorita);
            //usando dynamic da para mudar o tipo da variável

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contadorinteligente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contador Usuário");
            Console.Write("Digite o valor até queira contar: ");
            int c = int.Parse(Console.ReadLine());
            int contador = 1;
            while (c >= contador)
            {
                Console.Write($"{contador}.. ");
                contador++;
            }
            Console.WriteLine("Acabou!");
        }
    }
}

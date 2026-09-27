using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace salfuncionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int diaria = 25 * 8;
            Console.WriteLine("Cálculo de Salário");
            Console.Write("Nome do Funcionário: ");
            string nome = Console.ReadLine();
            Console.Write("Dias Trabalhados: ");
            int d = int.Parse(Console.ReadLine());
            double sal = d * diaria;
            Console.WriteLine($"O funcionário(a) {nome} irá receber {sal:F2}R$");
        }
    }
}

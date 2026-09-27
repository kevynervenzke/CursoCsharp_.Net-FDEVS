using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace nome_salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome do Funcionário: ");
            string nome = Console.ReadLine();
            Console.Write("Salário do Funcionário: ");
            string sal = Console.ReadLine();
            Console.Write("O funcionário " + nome + " tem um salário de " + sal);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace reajustesalario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reajuste de Salário");
            Console.Write("Nome do Funcionário: ");
            string nome = Console.ReadLine();
            Console.Write("Salário Atual [R$]: ");
            float sal_atual = float.Parse(Console.ReadLine());
            Console.Write("Sexo do Funcionário [M/F]: ");
            string sexo = Console.ReadLine();
            Console.Write("Quantos anos o funcionário trabalha na empresa: ");
            float a = float.Parse(Console.ReadLine());
            if (sexo == "f" || sexo == "F")
            {
                if (a < 15)
                {
                    float sal_novo = sal_atual + (sal_atual * 5) / 100;
                    Console.WriteLine($"O funcionário {nome}, trabalhou {a} anos e teve um aumento de 5% e seu salário novo é de {sal_novo}");
                }
                else if (a >= 15 && a < 20)
                {
                    float sal_novo = sal_atual + (sal_atual * 12) / 100;
                    Console.WriteLine($"O funcionário {nome}, trabalhou {a} anos e teve um aumento de 12% e seu salário novo é de {sal_novo}");
                }
                else if (a >= 20)
                {
                    float sal_novo = sal_atual + (sal_atual * 23) / 100;
                    Console.WriteLine($"O funcionário {nome}, trabalhou {a} anos e teve um aumento de 23% e seu salário novo é de {sal_novo}");
                }
            }
            if (sexo == "m" || sexo == "M")
            {
                if (a < 20)
                {
                    float sal_novo = sal_atual + (sal_atual * 3) / 100;
                    Console.WriteLine($"O funcionário {nome}, trabalhou {a} anos e teve um aumento de 3% e seu salário novo é de {sal_novo}");
                }
                else if (a >= 20 && a < 30)
                {
                    float sal_novo = sal_atual + (sal_atual * 13) / 100;
                    Console.WriteLine($"O funcionário {nome}, trabalhou {a} anos e teve um aumento de 13% e seu salário novo é de {sal_novo}");
                }
                else if (a >= 30)
                {
                    float sal_novo = sal_atual + (sal_atual * 25) / 100;
                    Console.WriteLine($"O funcionário {nome}, trabalhou {a} anos e teve um aumento de 25% e seu salário novo é de {sal_novo}");
                }
            }
        }
    }
}

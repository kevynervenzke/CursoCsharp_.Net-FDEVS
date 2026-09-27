using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace analisadordesalario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resp = "s";
            float TotSalM = 0;
            float TotSalF = 0;
            do
            {
                Console.WriteLine("Total de Salários: Homens e Mulheres");
                Console.Write("Qual seu Sexo: [M/F]: ");
                string sexo = Console.ReadLine().ToLower();
                Console.Write("Qual seu salário R$: ");
                float sal = float.Parse(Console.ReadLine());
                if (sexo.ToLower() == "m")
                {
                    TotSalM += sal;
                }
                else if (sexo.ToLower() == "f")
                {
                    TotSalF += sal;
                }
                else
                {
                    Console.WriteLine("Sexo Inválido!");
                }
                Console.Write("Deseja Continuar? [S/N]: ");
                resp = Console.ReadLine();
                if (resp.ToLower() == "s")
                {
                }else if (resp.ToLower() == "n")
                {
                    Console.WriteLine($"Total de Salário pago aos homens: {TotSalM:F2}");
                    Console.WriteLine($"Total de Salário pago às mulheres: {TotSalF:F2}");
                    Console.WriteLine("Fim do Programa");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Resposta Inválida!");
                }
                Console.ReadKey();
                Console.Clear();

            } while (resp.ToLower() == "s");
        }
    }
}

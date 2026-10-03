using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advinhando_Sexo_Criança
{
    
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Random random = new Random();
            int Numero = random.Next(1, 3);
            Console.WriteLine("===================================");
            Console.WriteLine("     Advinhando Sexo da Criança    ");
            Console.WriteLine("===================================");
            Console.Write("Digite o sexo da Criança [M/F]: ");
            Console.WriteLine("\n1 - Masculino.");
            Console.WriteLine("2 - Feminino");
            Console.WriteLine("===================================");
            Console.Write("Digite sua resposta: ");
            int sexo = int.Parse(Console.ReadLine());
            Console.WriteLine("===================================");
            switch (Numero)
            {    case 1:
                    if (sexo == Numero)
                    {
                        Console.WriteLine("Você Acertou!\nO sexo é Masculino!");

                    }
                    else
                    {
                        Console.WriteLine("Você Errou!\nO sexo é Feminino!");
                    }
                    break;
                case 2:
                    if (sexo == Numero)
                    {
                        Console.WriteLine("Você Acertou!\nO sexo é Feminino!");
                    }
                    else
                    {
                        Console.WriteLine("Você Errou!\nO sexo é Feminino!");
                    }
                    break;
            }
            
            }
        }
    }

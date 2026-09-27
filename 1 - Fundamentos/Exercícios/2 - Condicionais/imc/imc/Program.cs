using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace imc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo IMC");
            Console.Write("Qual sua altura (m): ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Qual seu peso (kg): ");
            float p = float.Parse(Console.ReadLine());
            float imc = p / (a * a);
            if (imc < 18.5f)
            {
                Console.WriteLine($"Seu IMC é de {imc:F2} e você está abaixo do peso!");
            }
            else if (imc >= 18.5f && imc < 25)
            {
                Console.WriteLine($"Seu IMC é de {imc:F2} e você está no peso ideal!");
            }
            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine($"Seu IMC é de {imc:F2} e você está com sobrepeso!");
            }
            else if (imc >= 30 && imc < 40)
            {
                Console.WriteLine($"Seu IMC é de {imc:F2} e você está com obesidade!");
            }
            else
            {
                Console.WriteLine($"Seu IMC é de {imc:F2} e você está com obesidade mórbida!");
            }
        }
    }
}


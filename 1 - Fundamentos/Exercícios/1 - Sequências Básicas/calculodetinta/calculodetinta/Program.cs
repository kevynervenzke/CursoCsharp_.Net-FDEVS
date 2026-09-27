using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace calculodetinta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos litros de tinta irei gastar?");
            Console.Write("Largura da Parede em metros: ");
            float l = float.Parse(Console.ReadLine());
            Console.Write("Altura da Parede em metros: ");
            float a = float.Parse(Console.ReadLine());
            float area = (l * a);
            float litro = (area / 2f);
            Console.WriteLine($"Como a parede tem {area:F2} metros quadrados irá gastar {litro} litros de tinta");
        }
    }
}
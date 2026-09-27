using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace analisadordeterrenos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Analisador de Terrenos");
            Console.Write("Qual o comprimento do terreno (m): ");
            float c = float.Parse(Console.ReadLine());
            Console.Write("Qual a largura do terreno (m): ");
            float l = float.Parse(Console.ReadLine());
            float a = l * c;
            if (a < 100f)
            {
                Console.WriteLine("Terreno Popular");
            }
            else if (a >= 100f && a < 500f)
            {
                Console.WriteLine("TERRENO MASTER");
            }
            else
            {
                Console.WriteLine("TERRENO VIP");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contador2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c = 11;
            Console.WriteLine("Contador 2");
            while (c > 3)
            {
                c--;
                Console.Write($"{c}.. ");
            }
            Console.WriteLine(" Acabou!");
        }
    }
}

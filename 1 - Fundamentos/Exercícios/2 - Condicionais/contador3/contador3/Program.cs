using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contador3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contador 3");
            int c = 100;
            while (c >= 0)
            {
                Console.WriteLine($"{c}");
                c -= 5;
            }
            Console.WriteLine("Acabou!");
        }
    }
}
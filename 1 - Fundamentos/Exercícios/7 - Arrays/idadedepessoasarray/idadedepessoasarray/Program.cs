using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idadedepessoasarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] idades = new int[8];
            string[] nomes = new string[8];
            string[] Nomes25 = new string[8];
            int[] Idade25 = new int[8];
            int MaiorIdade = 0;
            string MaiorNome = "";
            int PosicaoMaior = 0;
            float TotalIdades = 0;
            float MediaIdade = 0;
            float TotalPessoas = 0;
            Console.WriteLine("====================================");
            Console.WriteLine("         CADASTRO DE PESSOAS        ");
            Console.WriteLine("====================================");
            for(int contador = 0; contador < idades.Length; contador++)
            {
                Console.Write($"Qual o nome da {contador + 1}ª Pessoa: ");
                nomes[contador] = Console.ReadLine();
                Console.Write($"Qual a idade da {contador + 1}ª Pessoa: ");
                idades[contador] = int.Parse(Console.ReadLine());
                TotalIdades += idades[contador];
                TotalPessoas++;
                if (idades[contador] > 25)
                {
                    Nomes25[contador] = nomes[contador];
                    Idade25[contador] = idades[contador];
                }
                if (idades[contador] > MaiorIdade)
                {
                    MaiorIdade = idades[contador];
                    MaiorNome = nomes[contador];
                    PosicaoMaior = contador + 1;
                }
                Console.Clear();
            }
            MediaIdade = TotalIdades / TotalPessoas;
            Console.WriteLine("====================================");
            Console.WriteLine("          LISTA DE PESSOAS          ");
            Console.WriteLine("====================================");
            for(int i = 0; i < idades.Length; i++)
            {
                    Console.WriteLine($"{i + 1}ª Pessoa: {nomes[i]}");
                    Console.WriteLine($"Idade: {idades[i]} anos.");
            }
            Console.WriteLine("====================================");
            Console.WriteLine("    PESSOAS COM MAIS DE 25 ANOS     ");
            Console.WriteLine("====================================");
            for(int j = 0; j <Idade25.Length; j++)
            {
                if (Idade25[j] != 0)
                {
                    Console.WriteLine($"Posição {j + 1}: {Nomes25[j]}");
                    Console.WriteLine($"Idade: {Idade25[j]}");
                }
            }
            Console.WriteLine("====================================");
            Console.WriteLine("        MAIOR IDADE DIGITADA        ");
            Console.WriteLine("====================================");
            Console.WriteLine($"A maior idade digitada foi de {MaiorNome} com {MaiorIdade} anos que foi digitada na {PosicaoMaior}ª Posição.");
            Console.WriteLine();
            Console.WriteLine("====================================");
            Console.WriteLine("          MÉDIA DE IDADES           ");
            Console.WriteLine("====================================");
            Console.WriteLine($"A média de idades foi de {MediaIdade:F2} anos por pessoa");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        enum Cor {Azul, Verde, Amarelo, Vermelho}
        enum Opcao { Criar=1, Deletar=2, Editar=3, Listar=4, Atualizar=5 }

        static void Main(string[] args)
        {
            //for (int contador; condição, contador++)


            string[] palavras = { "Victor", "Lima", "Guia do prog", "Formação", "Node", "Curso de C#", "Udemy" };

            for(int contador = palavras.Length - 1; contador >= 0; contador--)
            {

                Console.WriteLine(palavras[contador]);
            }

            Console.WriteLine("Fim da Linha!");
            Console.ReadLine();      
        }
    }
}

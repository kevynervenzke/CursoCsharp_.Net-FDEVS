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
            //while => enquanto for verdade faça
            int contador = 0;
            while(contador < 20)
            {
                contador++;
                Console.WriteLine($"Rodando o While! {contador}");
                
            }
            Console.WriteLine("Fim do While!");

            Console.ReadLine();      
        }
    }
}

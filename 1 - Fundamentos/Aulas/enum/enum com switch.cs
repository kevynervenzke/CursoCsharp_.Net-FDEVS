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
            //Muito utilizados com switch para criar menus
            //usar dentro da class
            //são valores pre definidos
            //não podem ser mudados
            //Sempre que criar uma variável Cor vai poder usar só os itens do enum
            //Eles tem índice igual as arrays
            //Da pra personalizar o indice dos enum
            //Cada enumeração recebe um valor
            //Da pra passar o item para uma variável usando o tipo que é o nome do enum
            //se colocar o int antes você mostrará o indice do enum
            //se colocar o nome do enum antes você mostrará o nome do enum
            




            Console.WriteLine("Selecione uma das opções abaixo: ");
            Console.WriteLine("1 - Criar\n2 - Deletar\n3 - Editar\n4 - Listar\n5 - Atualizar");
            int index = int.Parse(Console.ReadLine());
            Opcao opcaoSelecionada = (Opcao)index;

            switch (opcaoSelecionada)
            {
                case Opcao.Criar:
                    Console.WriteLine("Você quer criar algo");
                    break;
                case Opcao.Deletar:
                    Console.WriteLine("Você quer deletar algo");
                    break;
                case Opcao.Editar:
                    Console.WriteLine("Você quer editar algo");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
            Console.ReadLine();      
        }
    }
}

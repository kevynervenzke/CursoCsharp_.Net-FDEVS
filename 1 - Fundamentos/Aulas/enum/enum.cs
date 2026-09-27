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
        enum Opcoes { Criar, Deletar, Editar, Listar, Atualizar}

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

            Console.ReadLine();      
        }
    }
}

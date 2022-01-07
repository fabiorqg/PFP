using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_NomeCompleto_v1
{

    class Program
    {

        static void Main(string[] args)
        {

            // Declarar variáveis
            string nomePrimeiro, nomeMeio, nomeUltimo, nomeCompleto;

            // Ler: primeiro, meio e último nomes
            Console.Write("Primeiro nome: ");
            nomePrimeiro = Console.ReadLine();

            Console.Write("Nome do meio: ");
            nomeMeio = Console.ReadLine();

            Console.Write("Último nome: ");
            nomeUltimo = Console.ReadLine();

            // Concatenar nome completo
            nomeCompleto = nomePrimeiro + " " + nomeMeio + " " + nomeUltimo;

            // Mostrar nome completo
            Console.WriteLine("Nome completo: " + nomeCompleto);

            // Pausar a consola
            Console.ReadKey();

        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_NomeCompleto_v2
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
            if (!string.IsNullOrEmpty(nomePrimeiro) && !string.IsNullOrEmpty(nomeMeio) && !string.IsNullOrEmpty(nomeUltimo))
            {
                nomeCompleto = $"{nomePrimeiro} {nomeMeio} {nomeUltimo}";
            }
            else if (!string.IsNullOrEmpty(nomePrimeiro) && string.IsNullOrEmpty(nomeMeio) && string.IsNullOrEmpty(nomeUltimo))
            {
                nomeCompleto = nomePrimeiro;
            }
            else if (!string.IsNullOrEmpty(nomePrimeiro) && !string.IsNullOrEmpty(nomeMeio) && string.IsNullOrEmpty(nomeUltimo))
            {
                nomeCompleto = $"{nomePrimeiro} {nomeMeio}";
            }
            else if (!string.IsNullOrEmpty(nomePrimeiro) && string.IsNullOrEmpty(nomeMeio) && !string.IsNullOrEmpty(nomeUltimo))
            {
                nomeCompleto = $"{nomePrimeiro} {nomeUltimo}";
            }
            else if (string.IsNullOrEmpty(nomePrimeiro) && !string.IsNullOrEmpty(nomeMeio) && string.IsNullOrEmpty(nomeUltimo))
            {
                nomeCompleto = nomeMeio;
            }
            else if (string.IsNullOrEmpty(nomePrimeiro) && !string.IsNullOrEmpty(nomeMeio) && !string.IsNullOrEmpty(nomeUltimo))
            {
                nomeCompleto = $"{nomeMeio} {nomeUltimo}";
            }
            else if (string.IsNullOrEmpty(nomePrimeiro) && string.IsNullOrEmpty(nomeMeio) && !string.IsNullOrEmpty(nomeUltimo))
            {
                nomeCompleto = nomeUltimo;
            }
            else
            {
                nomeCompleto = "<sem nome>";
            }

            // Mostrar nome completo
            Console.WriteLine($"\nNome completo: {nomeCompleto}\n\n");

            // Pausar a consola
            Console.ReadKey();

        }

    }

}

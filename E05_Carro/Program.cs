using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E05_Carro
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                Carro carro01 = new Carro();        //1º construtor: carro vazio
                carro01.Criarv1();
                carro01.Listar("1");

                Carro carro02 = new Carro("Marca X", " Modelo X", "Cor X", "Matricula X", 1, 11);
                carro02.Listar("2");

                Carro carro03 = new Carro("Matricula y", 2, 22);
                carro03.Criarv2();
                carro03.Listar("3");
            }
            catch (Exception ex)
            {

                Console.WriteLine("\n\nERROR");
                Console.Write($"Detalhe do ERROR: {ex.Message}");
                Console.ReadKey();
            }

            Console.ReadKey();
        }
    
    }

}

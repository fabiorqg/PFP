using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
   
    class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                // classe nomeObjeto = new Constructor();
                CalculadoraSimples novaOperacao01 = new CalculadoraSimples();

                CalculadoraSimples novaOperacao02 = new CalculadoraSimples(10, 5, "+");

                novaOperacao01.EscreverOperacoesPossiveis();
                novaOperacao01.LerValor1();
                novaOperacao01.LerValor2();
                novaOperacao01.LerOperador();

                if (novaOperacao01.TestarOperador())
                {
                    novaOperacao01.UsarOperador();
                    novaOperacao01.EscreverResultado();
                }
                else
                {
                        Console.WriteLine("Não foi posssivel realizar a operação");
                }
              
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Atenção ao Argumento");
            }
            catch (Exception)  // "catch (Exception erro)"
            {
                //Console.WriteLine(erro.Message); //serve para logar o erro
                Console.WriteLine("Consola deu erro..");
            }

            Console.ReadKey();
        
        }
   
    }

}

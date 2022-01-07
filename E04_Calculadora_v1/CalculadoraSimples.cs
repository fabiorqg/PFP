using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    
    class CalculadoraSimples
    {
        #region Properties
        public double Valor1 { get; set; }
        public double Valor2 { get; set; }
        public string Operador { get; set; }
        public double Resultado { get; set; }

        #endregion

        #region Constructors
        public CalculadoraSimples()
        {
            Valor1 = 0;
            Valor2 = 0;
            Operador = string.Empty;  // ""
            Resultado = 0;
        }

        public CalculadoraSimples(double valor1, double valor2, string operacao)
        {
            Valor1 = valor1;
            Valor2 = valor2;
            Operador = operacao;
            Resultado = 0;
        }
        #endregion

        #region Methods
        public void EscreverOperacoesPossiveis()
        {
            Console.Write("Operações:\n");
            //Console.Write("\n[+]\n[-]\n[*]\n[/]\n\n");
            string[] mostrarOperacoes = new string[]
            {
                "[+]",
                "[-]",
                "[*]",
                "[/]"
            };
            foreach (string escreverOps in mostrarOperacoes)
            {
                Console.WriteLine(escreverOps);
            }
        }

        public void LerValor1()
        {
            Console.Write("Valor 1: ");
            Valor1 = Double.Parse(Console.ReadLine());
        }

        public void LerValor2()
        {
            Console.Write("Valor 2: ");
            Valor2 = Double.Parse(Console.ReadLine());
        }

        public void LerOperador()
        {
            Console.Write("Operação: ");
            Operador = Console.ReadLine();
        }

        public bool TestarOperador()
        {
             var validado = false;
            
            switch (Operador)
            {
                case "+":
                    validado = true;    
                    break;
                case "-":
                    validado = true;
                    break;
                case "*":
                    validado = true;
                    break;
                case "/":
                    validado = true;
                    break;
                default:
                    validado = false;
                    Console.Write("Erro");
                    break;
            }
            return validado;
        }

        public void UsarOperador()
        {
            switch (Operador)
            {
                case "+":
                    Soma();
                    break;
                case "-":
                    Subtracao();
                    break;
                case "*":
                    Multiplicacao();
                    break;
                case "/":
                    Divisao();
                    break;
            }
        }
        public void Soma()
        {
            Resultado = Valor1 + Valor2;
        }
        
        public void Subtracao()
        {
            Resultado = Valor1 - Valor2;
        }

        public void Multiplicacao()
        {
            Resultado = Valor1 * Valor2;
        }

        public void Divisao()
        {
            //Resultado = Valor1 / Valor2;
            if (Valor2 == 0)
            {
                Resultado = 0;
            }
            else
            {
                Resultado = Valor1 / Valor2;
            }

        }

        public void EscreverResultado()
        {
            Console.Write($"\n\nResultado: {Resultado}");
        }

        #endregion
    }

}

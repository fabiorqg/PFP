using System;

namespace D06_EstruturasCondicionais
{

    class Program
    {

        static void Main(string[] args)
        {

            #region Variáveis
            int numero = 0;
            #endregion

            #region IF simples
            Console.WriteLine("IF simples\n");

            if (numero == 1000)
                Console.WriteLine("Número = 1000");

            if (numero == 0)
            {
                Console.WriteLine("Número = 0");
            }

            Console.ReadKey();
            Console.Clear();
            #endregion

            #region IF...ELSE
            Console.WriteLine("IF...ELSE\n");

            if (numero == 10)
            {
                Console.WriteLine("Número = 10");
            }
            else
            {
                Console.WriteLine("Número <> 10");
            }

            Console.ReadKey();
            Console.Clear();
            #endregion

            #region IF encadeado
            Console.WriteLine("IF encadeado\n");

            if (numero == 0)
            {
                Console.WriteLine("Número = 0");
            }
            else
            {
                if (numero == 10)
                {
                    Console.WriteLine("Número = 10");
                }
                else
                {
                    if (numero == 15)
                    {
                        Console.WriteLine("Número = 15");
                    }
                    else
                    {
                        Console.WriteLine("Número diferente de 0, 10 e 15");
                    }
                }
            }

            Console.ReadKey();
            Console.Clear();
            #endregion

            #region IF...ELSEIF
            Console.WriteLine("IF...ELSEIF\n");

            if (numero == 0)
            {
                Console.WriteLine("Número = 0");
            }
            else if (numero == 10)
            {
                Console.WriteLine("Número = 10");
            }
            else if (numero == 15)
            {
                Console.WriteLine("Número = 15");
            }
            else if (numero == 20)
            {
                Console.WriteLine("Número = 20");
            }
            else
            {
                Console.WriteLine("Número diferente de 0, 10, 15 e 20");
            }

            Console.ReadKey();
            Console.Clear();
            #endregion

            #region SWITCH
            Console.WriteLine("SWITCH\n");

            //Enumerations
            switch (numero)
            {
                case 0: // igual a
                    Console.WriteLine("O número = 0");
                    break;
                case 10:
                    Console.WriteLine("O número = 10");
                    break;
                case 15:
                    Console.WriteLine("O número = 15");
                    break;
                case 20:
                    Console.WriteLine("O número = 20");
                    break;
                default:
                    Console.WriteLine("Número diferente de 0, 10, 15 e 20");
                    break;
            }
            #endregion

            Console.ReadKey();
            Console.Clear();

        }

    }

}

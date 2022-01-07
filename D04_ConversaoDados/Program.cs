using System;

namespace D04_ConversaoDados
{

    class Program
    {

        static void Main(string[] args)
        {

            #region Variáveis
            string s1 = "1";
            string s2 = "2";
            int i1 = 10;
            int i2 = 20;
            long l1 = 3000000;
            float f1 = 30.5F;
            double d1 = 7.1;
            #endregion

            #region Não conversão
            Console.WriteLine(s1 + i1);                     // "110" string + int --> concatenou
            Console.WriteLine(i1 + i2);                     // 30   int + int --> somou
            #endregion

            #region Conversão implícita
            Console.WriteLine(f1 + i1);                     // 40.5
            #endregion

            #region Conversão explícita
            // ToString(): int to string
            Console.WriteLine(i2.ToString() + s2);          // 202

            // Convert: string to int
            // Classe Convert usa métodos de conversão dos diferentes tipos de dados
            Console.WriteLine(i2 + Convert.ToInt16(s2));   // 22
            
            // Parse: string to double
            // Parse é um método do tipo de dados numérico
            Console.WriteLine(d1 + double.Parse(s1));       // 8,1
            
            // Cast: int to long
            // Cast é um operador que antecede o tipo de dados a converter
            Console.WriteLine((long)i2 + l1);               // 3000020

            // Cast: float to double (f1 + d1)
            Console.WriteLine((double)f1 + d1);             // 37,6

            // Cast: double to int (d1 + i1)
            Console.WriteLine((int)d1 + i1);                // 20
            #endregion

            Console.ReadKey();

        }

    }

}

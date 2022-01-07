using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionarioDadosPessoais
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            FuncionarioNome funcionario01 = new FuncionarioNome();

            funcionario01.LerPrimeiroNome();
            funcionario01.LerNomeDoMeio();
            funcionario01.LerUltimoNome();
            funcionario01.VerificarCasosDoNome();
            funcionario01.EscreverNomeCompleto();

            Console.ReadKey();

        }
    
    }

}

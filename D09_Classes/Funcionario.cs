using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH
{
    class Funcionario
    {
        #region Properties
        public string Nome { get; set; }
        public string Email { get; set; }
        #endregion

        #region Methods
        public void LerNome()
        {
            
            Console.Write("Nome: ");
            Nome = Console.ReadLine();
            
        }

        public void LerEmail()
        {
            
            Console.Write("Email: ");
           Email = Console.ReadLine();

        }

        public void EscreverMensagem() 
        {

            Console.Write($"\nO funcionário {Nome.ToUpper()} tem o email {Email}.");

        }
        #endregion




    }
}

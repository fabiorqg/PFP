using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionarioDadosPessoais
{
    
    class FuncionarioNome
    {
        #region Properties
        public string PrimeiroNome { get; set; }
        public string NomeDoMeio { get; set; }
        public string UltimoNome { get; set; }
        public string NomeCompleto { get; set; }

        #endregion

        #region Methods
        public void LerPrimeiroNome()
        {
            Console.Write("Escreva o seu primeiro nome: ");
            PrimeiroNome = Console.ReadLine();
        }
        
        public void LerNomeDoMeio()
        {
            Console.Write("Escreva o seu nome do meio: ");
            NomeDoMeio = Console.ReadLine();
        }
        
        public void LerUltimoNome()
        {
            Console.Write("Escreva o seu último nome: ");
            UltimoNome = Console.ReadLine();
        }

        public void VerificarCasosDoNome()
        {
            if (!string.IsNullOrEmpty(PrimeiroNome) && !string.IsNullOrEmpty(NomeDoMeio) && !string.IsNullOrEmpty(UltimoNome))
            {
                NomeCompleto = $"{PrimeiroNome} {NomeDoMeio} {UltimoNome}";
            }
            else if (!string.IsNullOrEmpty(PrimeiroNome) && string.IsNullOrEmpty(NomeDoMeio) && string.IsNullOrEmpty(UltimoNome))
            {
                NomeCompleto = PrimeiroNome;
            }
            else if (!string.IsNullOrEmpty(PrimeiroNome) && !string.IsNullOrEmpty(NomeDoMeio) && string.IsNullOrEmpty(UltimoNome))
            {
                NomeCompleto = $"{PrimeiroNome} {NomeDoMeio}";
            }
            else if (!string.IsNullOrEmpty(PrimeiroNome) && string.IsNullOrEmpty(NomeDoMeio) && !string.IsNullOrEmpty(UltimoNome))
            {
                NomeCompleto = $"{PrimeiroNome} {UltimoNome}";
            }
            else if (string.IsNullOrEmpty(PrimeiroNome) && !string.IsNullOrEmpty(NomeDoMeio) && string.IsNullOrEmpty(UltimoNome))
            {
                NomeCompleto = NomeDoMeio;
            }
            else if (string.IsNullOrEmpty(PrimeiroNome) && !string.IsNullOrEmpty(NomeDoMeio) && !string.IsNullOrEmpty(UltimoNome))
            {
                NomeCompleto = $"{NomeDoMeio} {UltimoNome}";
            }
            else if (string.IsNullOrEmpty(PrimeiroNome) && string.IsNullOrEmpty(NomeDoMeio) && !string.IsNullOrEmpty(UltimoNome))
            {
                NomeCompleto = UltimoNome;
            }
            else
            {
                NomeCompleto = "<sem nome>";
            }
        }

        public void EscreverNomeCompleto()
        {
            Console.Write($"O seu nome completo é: {NomeCompleto}");           
        }
        
        
        #endregion

    }

}

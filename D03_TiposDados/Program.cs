using System;

namespace D03_TiposDados
{

    class Program
    {

        static void Main(string[] args)
        {
            //Categorias:
            // value e reference types
            //value types:geridos na stack
            //value: bool + numéricos
            //reference types: geridos na heap (é imutável!!)
            //reference: string + datatime + classes



            #region 1. Declarar variáveis
            byte idade;
            bool inscrito;
            string nome;
            double altura;
            DateTime data;
            DateTime hora;
            DateTime dataHoraAtuais;    // timestamp
            DateTime dataAtual;
            DateTime dataVazia;
            #endregion

            #region 2. Atribuir valores às variáveis
            idade = 1;
            inscrito = true;
            nome = "Pessoa";
            altura = 1.6;
            data = new DateTime(2021, 10, 05);
            hora = new DateTime(2021, 10, 05, 10, 30, 0);
            dataHoraAtuais = DateTime.Now;
            dataAtual = DateTime.Today;
            dataVazia = DateTime.MinValue;
            #endregion

            #region 3. Listar as variáveis
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("TIPOS DE DADOS");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Byte\t\tIdade: " + idade);
            Console.WriteLine("Boolean\t\tInscrito? " + inscrito);
            Console.WriteLine("String\t\tNome: " + nome);
            Console.WriteLine("Double\t\tAltura: " + altura);
            Console.WriteLine("DateTime\tData short: " + data.ToShortDateString());
            Console.WriteLine("DateTime\tData: " + data);
            Console.WriteLine("DateTime\tHora short: " + hora.ToShortTimeString());
            Console.WriteLine("DateTime\tHora long: " + hora.ToLongTimeString());
            Console.WriteLine("DateTime\tData e horas atuais (timestamp): " + dataHoraAtuais);
            Console.WriteLine("DateTime\tData atual: " + dataAtual.ToShortDateString());
            Console.WriteLine("DateTime\tData vazia: " + dataVazia.ToShortDateString());
            #endregion

            #region 4. Pausar a consola 
            Console.ReadKey();
            #endregion


        }

    }

}

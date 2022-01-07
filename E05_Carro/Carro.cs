using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E05_Carro
{
    class Carro
    {
        
        #region Enumerations
        public enum EnumMarca
        {
            Audi,
            BMW,
            VOLVO
        }
        public enum EnumModelo
        {
            A3Sportback,
            A5Coupé,
            Serie1,
            BMMWCoupé,
            Volvo01,
            Volvo02
        }
        public enum EnumCor
        {
            Branco,
            Preto,
            Azul,
            Vermelho,
            Verde
        }
        #endregion

        #region Properties
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public string Matricula { get; set; }
        public int Cilindrada { get; set; }
        public int Velocidade { get; set; }
        #endregion

        #region Constructors
        public Carro()
        {
            Marca = string.Empty;
            Modelo = string.Empty;
            Cor = string.Empty;
            Matricula = string.Empty;
            Cilindrada = 0;
            Velocidade = 0;
        }
        public Carro(string marca1, string modelo1, string cor1, string matricula1, int cilindrada1, int velocidade1)
        {
            Marca = marca1;
            Modelo = modelo1;
            Cor = cor1;
            Matricula = matricula1;
            Cilindrada = cilindrada1;
            Velocidade = velocidade1;
        }
        public Carro(string matricula1, int cilindrada1, int velocidade1)
        {
            Marca = string.Empty;
            Modelo = string.Empty;
            Cor = string.Empty;
            Matricula = matricula1;
            Cilindrada = cilindrada1;
            Velocidade = velocidade1;
        }
        #endregion

        #region Methods 
        public void Criarv1()
        {
            Console.Clear();
            Console.Write("Escreve a marca: ");
            Marca = Console.ReadLine();
            Console.Write("Escreve o modelo pretendido: ");
            Modelo = Console.ReadLine();
            Console.Write("Diz que cor pretendes: ");
            Cor = Console.ReadLine();
            Console.Write("Matricula: ");
            Matricula = Console.ReadLine();
            Console.Write("A cilindrada é: ");
            Cilindrada = Convert.ToInt16(Console.ReadLine());
            Console.Write("A velocidade é: ");
            Velocidade = Convert.ToInt16(Console.ReadLine());
        }

        public void Criarv2()
        {
            Console.Clear();
            Console.Write("Matricula: ");
            Matricula = Console.ReadLine();
            Console.Write("A cilindrada é: ");
            Cilindrada = Convert.ToInt16(Console.ReadLine());
            Console.Write("A velocidade é: ");
            Velocidade = Convert.ToInt16(Console.ReadLine());
        }

        public void Listar(string titulo)
        {
            Console.Clear();
            Console.WriteLine($"---------------------------------\nCARRO{titulo}\n---------------------------------\n");

            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Cor: {Cor}");
            Console.WriteLine($"Matricula: {Matricula}");
            Console.WriteLine($"Cilindrada: {Cilindrada}");
            Console.WriteLine($"Velocidade: {Velocidade}");

            Console.ReadKey();
        }

        public void Parar()
        {
            Velocidade = 0;
        }

        public void Acelerar(int valor)
        {
            Velocidade = Velocidade + valor;
        }

        public void Desacelerar(int valor)
        {
            Velocidade = Velocidade - valor;
        }

        #endregion

        #region Destructor
        ~Carro()
        {
            //GC --> Garbage Collector
            // Para ver a mensagem executar com -- < CTRL + F5
            // Console.WriteLine("O carro vai para a sucata");
        }
        #endregion
    }

}

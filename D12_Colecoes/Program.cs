using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D12_Colecoes
{
    
    class Program
    {
       
        static void Main(string[] args)
        {

            #region ArrayList: Inteiros
            //1. Instanciar
            ArrayList numbersList = new ArrayList();

            //2. Adicionar valores  com o método Add
            numbersList.Add(100);
            numbersList.Add(2);
            numbersList.Add(-3);
            numbersList.Add(43);

            //3. Adicionar com FOR
            for (int i = 5; i <= 10; i++)  // == "for (int i = 5; i < 11; i++)"
            {
                numbersList.Add(i);
            }

            //3.1 FOR do 500 ao 520, increment 2
            for (int i = 500; i <521 ; i = i + 2)
            {
                numbersList.Add(i);
            }

            //4. Listar com FOREACH
            foreach (int item in numbersList)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            #endregion
            
            Console.Clear();
           
            #region ArrayList: Strings
            //1. Instanciar e adicionar valores
            ArrayList stringsList = new ArrayList()
            {
                "a",
                "b",
                "c",
                "d"
            };

            stringsList.Add("C#");
            stringsList.Add("Microsoft");
            Console.WriteLine("Nova string");   
            stringsList.Add(Console.ReadLine()); // Adicionar valor pela consola

            //2.Listar
            foreach (string item in stringsList)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadKey();

            #endregion

            Console.Clear();

            #region ArrayList: Pessoas
            
            ArrayList PersonList = new ArrayList();

            Person person01 = new Person();
            Person person02 = new Person();

            person01.Name = "Gonçalo";
            person01.Location = "Melres";

            person02.Name = "Bruno";
            person02.Location = "Zé Dos cães";

            PersonList.Add(person01);
            PersonList.Add(person02);

            foreach (Person item in PersonList)
            {
                Console.WriteLine($"Nome: {item.Name} \t\t Localidade: {item.Location}");
            }

            Console.ReadKey();
            #endregion

            Console.Clear();

            #region Arraylist: Funcionários
            ArrayList employeeList = new ArrayList();
            
            Employee employee01 = new Employee();
            Employee employee02 = new Employee();
            Employee employee03 = new Employee();

            employee01.Name = "João";
            employee01.Location = "Residencial Cairence";
            employee01.Department = "Recursos Humanos";

            employee02.Name = "Rato";
            employee02.Location = "Caverna";
            employee02.Department = "Desemprego";

            employeeList.Add(employee01);
            employeeList.Add(employee02);

            foreach (Employee item in employeeList)
            {
                Console.WriteLine($"Nome: {item.Name} \t\t Localidade: {item.Location} \t\t Departamento: {item.Department}");
            }
            Console.ReadKey();
            #endregion

        }

    }

}

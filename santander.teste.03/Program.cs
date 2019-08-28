using Newtonsoft.Json;
using santander.teste._03.Service;
using System;

namespace santander.teste._03
{
    public class Program
    {
        private static PersonManager personManager = new PersonManager();

        static void Main(string[] args)
        {
            PopulatePerson();
            DeletePerson();
            Console.ReadKey();
        }

        static void PopulatePerson()
        {
            personManager.AddPerson("Teste 01", "01/01/1981");
            personManager.AddPerson("Teste 02", "01/02/1982");
            personManager.AddPerson("Teste 03", "01/03/1983");
            personManager.AddPerson("Teste 04", "01/04/1984");
            personManager.AddPerson("Teste 05", "01/05/1985");
            personManager.AddPerson("Teste 06", "01/06/1986");
            personManager.AddPerson("Teste 07", "01/07/1987");
            personManager.AddPerson("Teste 08", "01/08/1988");
            personManager.AddPerson("Teste 09", "01/09/1989");
            personManager.AddPerson("Teste 10", "01/10/1990");

            string list = JsonConvert.SerializeObject(personManager.DB);

            Console.WriteLine(list);
        }

        static void DeletePerson()
        {
            personManager.DeletePerson(0);
            personManager.DeletePerson(3);
            personManager.DeletePerson(6);

            string list = JsonConvert.SerializeObject(personManager.DB);

            Console.WriteLine(list.ToString());
        }

    }
}

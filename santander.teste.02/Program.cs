using System;
using santander.teste._02.Services;

namespace santander.teste._02
{
    class Program
    {

        static void Main(string[] args)
        {
            string carId = Console.ReadLine();
            string mileage = Console.ReadLine();
            string description = "";

            try
            {
                CarService service = new CarService(carId, mileage);
                description = service.getCar();
                Console.WriteLine(description);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }            

            Console.ReadKey();
        }
    }
}

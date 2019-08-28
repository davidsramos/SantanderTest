using santander.teste._02.Abstraction;
using santander.teste._02.Entities;
using System;

namespace santander.teste._02.Services
{
    public class CarService
    {
        private int carId;
        private int mileage;

        public CarService(string carId, string mileage)
        {
            this.carId = validateCarId(carId);
            this.mileage = validateMileage(mileage);
        }

        private int validateCarId(string carId)
        {
            var intVal = int.Parse(carId);

            if(intVal < 0 || intVal > 2)
            {
                throw new Exception("The first value must be between 0 and 2");
            }

            return intVal;
        }

        private int validateMileage(string mileage)
        {
            var intVal = int.Parse(mileage);

            if (intVal < 5 || intVal > 30)
            {
                throw new Exception("The second value must be between 5 and 30");
            }

            return intVal;
        }

        public string getCar()
        {
            Car car;
            string desc = "";

            switch (carId)
            {
                case 0:
                    car = new WagonR(mileage);
                    desc = car.ToString();
                    break;
                case 1:
                    car = new HondaCity(mileage);
                    desc = car.ToString();
                    break;
                case 2:
                    car = new InnovaCrysta(mileage);
                    desc = car.ToString();
                    break;
            }

            return desc;
        }

    }
}

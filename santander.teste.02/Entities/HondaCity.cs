using santander.teste._02.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace santander.teste._02.Entities
{
    public class HondaCity : Car
    {
        private int mileage;

        public HondaCity(int _mileage) : base (true, "4")
        {
            mileage = _mileage;
        }

        public override string getMileage()
        {
            return mileage.ToString() + " kmpl";
        }

        public override string ToString()
        {
            string isSedan = (getIsSedan()) ? "is sedan" : "is not a sedan";

            return String.Format("A HondaCity {0}, is {1}, and has a mileage of around {2}.", isSedan, getSeats(), getMileage());                
        }
    }
}

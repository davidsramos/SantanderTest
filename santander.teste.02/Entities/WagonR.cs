using santander.teste._02.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace santander.teste._02.Entities
{
    class WagonR : Car
    {
        private int mileage;

        public WagonR(int _mileage) : base(false, "4")
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

            return String.Format("A WagonR {0}, is {1}, and has a mileage of around {2}.", isSedan, getSeats(), getMileage());
        }
    }
}

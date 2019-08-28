using santander.teste._02.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace santander.teste._02.Entities
{
    class InnovaCrysta : Car
    {
        private int mileage;

        public InnovaCrysta(int _mileage) : base(false, "6")
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

            return String.Format("A InnovaCrysta {0}, is {1}, and has a mileage of around {2}.", isSedan, getSeats(), getMileage());
        }

    }
}

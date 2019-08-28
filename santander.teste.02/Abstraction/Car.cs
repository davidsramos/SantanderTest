using System;
using System.Collections.Generic;
using System.Text;

namespace santander.teste._02.Abstraction
{
    public abstract class Car
    {
        private Boolean isSedan;
        private String seats;

        protected Car(bool isSedan, string seats)
        {
            this.isSedan = isSedan;
            this.seats = seats;
        }

        public Boolean getIsSedan()
        {
            return isSedan;
        }

        public String getSeats()
        {
            return String.Format("{0}-seater", seats);
        }

        public abstract String getMileage();

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BikeLibrary.model
{
    public class ABuy
    {
        private Bike _bike;
        private Customer _customer;

        public ABuy()
        {
        }

        public ABuy(Bike bike, Customer customer)
        {
            _bike = bike;
            _customer = customer;
        }

        public Bike Bike
        {
            get => _bike;
            set => _bike = value;
        }

        public Customer Customer
        {
            get => _customer;
            set => _customer = value;
        }

        public override string ToString()
        {
            return $"{nameof(Bike)}: {Bike}, {nameof(Customer)}: {Customer}";
        }
    }
}

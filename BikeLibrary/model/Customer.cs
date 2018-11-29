using System;
using System.Collections.Generic;
using System.Text;

namespace BikeLibrary.model
{
    public class Customer
    {
        private string _name;
        private String _phone;

        public Customer()
        {
        }

        public Customer(string name, string phone)
        {
            _name = name;
            _phone = phone;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Phone
        {
            get => _phone;
            set => _phone = value;
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Phone)}: {Phone}";
        }
    }
}

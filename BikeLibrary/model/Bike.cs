using System;
using System.Collections.Generic;
using System.Text;

namespace BikeLibrary.model
{
    public class Bike
    {
        private int _id;
        private int _size;
        private String _bikeType;
        private int _price;

        public Bike()
        {
        }

        public Bike(int id, int size, string bikeType, int price)
        {
            _id = id;
            _size = size;
            _bikeType = bikeType;
            _price = price;
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public int Size
        {
            get => _size;
            set => _size = value;
        }

        public string BikeType
        {
            get => _bikeType;
            set => _bikeType = value;
        }

        public int Price
        {
            get => _price;
            set => _price = value;
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Size)}: {Size}, {nameof(BikeType)}: {BikeType}, {nameof(Price)}: {Price}";
        }
    }
}

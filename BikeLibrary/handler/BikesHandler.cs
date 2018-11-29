using System;
using System.Collections.Generic;
using System.Text;
using BikeLibrary.model;

namespace BikeLibrary.handler
{
    public class BikesHandler
    {
        private static BikesHandler _instance = new BikesHandler();

        public static BikesHandler Instance => _instance;


        private List<Bike> _bikes;
    private BikesHandler()
        {
            _bikes = new List<Bike>()
            {
                new Bike(1, 28, "men", 5600),
                new Bike(2, 26, "men", 4700),
                new Bike(3, 12, "kids", 3100),
                new Bike(4, 26, "lady", 4800),
                new Bike(5, 28, "men", 5700)
            };
        }


        public List<Bike> GetAll()
        {
            return _bikes;
        }

        public Bike GetFromId(int id)
        {
            return _bikes.Find( b => b.Id == id);
        }

        public List<Bike> GetByType(string bikeType)
        {
            return _bikes.FindAll( b => b.BikeType == bikeType);
        }

        
        /*
         * For buy a bike
         */

        public static List<ABuy> BoughtBikes { get; } = new List<ABuy>();

        public bool BuyBike(int id, Customer customer)
        {
            Bike bike = GetFromId(id);
            if (bike == null || customer == null)
            {
                return false;
            }

            BoughtBikes.Add(new ABuy(bike, customer));
            return true;
        }
    }
}

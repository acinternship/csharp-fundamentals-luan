using System.Collections.Generic;
using Test.Models;


namespace Test.Serveces
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant {Id = 1, Name = "Tersiguel's" },
                new Restaurant {Id = 2, Name = "LJ's and the Kat" },
                new Restaurant {Id = 1, Name = "King's Contrivence" }
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return null;
        }

        List<Restaurant> _restaurants;
    }
}

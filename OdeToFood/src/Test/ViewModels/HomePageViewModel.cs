using System.Collections.Generic;
using Test.Entities;

namespace Test.ViewModels
{
    public class HomePageViewModel
    {
        public IEnumerable<Restaurant> Restaurants{ get; set; }
        public string CurrentGreeting { get; set; }
    }
}

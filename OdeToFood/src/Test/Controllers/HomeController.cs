using Microsoft.AspNetCore.Mvc;
using Test.Models;
using Test.Serveces;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        private IRestaurantData _restaurantData;

        public HomeController(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }

        public ViewResult Index()
        {
            var model = _restaurantData.GetAll();

            return View(model);
        }
    }
}

using System.ComponentModel.DataAnnotations;
using Test.Entities;

namespace Test.ViewModels
{
    public class RestaurantEditViewModel
    {
        [Required, MaxLength(80)]
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}

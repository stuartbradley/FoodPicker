using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodPicker.Models
{
    public class Meal
    {   
        public int Id { get; set; }
        public string Name { get; set; }
        public Ingredient[] Ingredients { get; set;}
    }
}
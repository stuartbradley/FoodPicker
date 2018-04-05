using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FoodPicker.Data;

namespace FoodPicker.Controllers
{
    public class MealsController : Controller
    {
        private FoodRepository foodRepository = null;

        public MealsController()
        {
            foodRepository = new FoodRepository();
        }

        public String Index()
        {
            return "this is it";
        }

        public ActionResult Detail(int? id)
        {
            var food = foodRepository.GetMeal(id.Value);
            return View(food);
        }

    }
}
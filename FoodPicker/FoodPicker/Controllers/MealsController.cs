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

        public ActionResult Detail(String id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var food = foodRepository.GetStringMeal(id);
            return View(food);
        }

        public ActionResult Detail()
        {
            var food = foodRepository.GetRandomMeal();
            return View(food);
        }

    }
}
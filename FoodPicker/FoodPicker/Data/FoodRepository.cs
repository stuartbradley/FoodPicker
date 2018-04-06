using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FoodPicker.Models;


namespace FoodPicker.Data
{
    public class FoodRepository
    {
        private static Meal[] meals = new Meal[]
        {
            new Meal()
            {
                Id = 1,
                Name = "fish and chips",
                Ingredients = new Ingredient[]
                {
                    new Ingredient() {Name = "fish"},
                    new Ingredient() {Name = "chips"},
                    new Ingredient() {Name = "peas"}
                } 
            },
            new Meal()
            {
                Id = 2,
                Name = "fajitas",
                Ingredients = new Ingredient[]
                {
                    new Ingredient() {Name = "kit"},
                    new Ingredient() {Name = "chicken"},
                    new Ingredient() {Name = "pepper"},
                    new Ingredient() {Name = "onions"}
                }
            },
            new Meal()
            {
                Id = 3,
                Name = "cumberland Pie",
                Ingredients = new Ingredient[]
                {
                    new Ingredient() {Name = "Cumberland Pie ready meal"}
                }
            }, 
            new Meal()
            {   Id = 4,
                Name = "spag and Balls",
                Ingredients = new Ingredient[]
                {
                    new Ingredient() {Name = "Spagetti"},
                    new Ingredient() {Name = "Meatballs"},
                    new Ingredient() {Name = "Sauce"},
                    new Ingredient() {Name = "Garlic bread"}
                }
            },
            new Meal()
            {
                Id = 5,
                Name = "toad in the hole",
                Ingredients = new Ingredient[]
                {
                    new Ingredient() { Name = "sausages"},
                    new Ingredient() { Name = "Potatoes"}, 
                    new Ingredient() { Name = "yorkshire puddings"},
                    new Ingredient() { Name = "Gravy"}
                }
            }, 
            new Meal()
            {
                Id = 6,
                Name = "corned beef hash",
                Ingredients = new Ingredient[]
                {
                    new Ingredient() {Name = "Potatoes"}, 
                    new Ingredient() {Name = "corned beef"}, 
                    new Ingredient() {Name = "carrots"},
                    new Ingredient() {Name = "gravy"}
                }
            }
        };
        public Meal GetNumberedMeal(int? id)
        {
            Meal MealToreturn = null;
            foreach(var meal in meals)
            {
                if(meal.Id == id)
                {
                    MealToreturn = meal;
                    break;
                }
                
            }
            return MealToreturn;
        }

        public Meal GetStringMeal(String name)
        {
            Meal MealToreturn = null;
            foreach (var meal in meals)
            {
                if (meal.Name == name)
                {
                    MealToreturn = meal;
                    break;
                }

            }
            return MealToreturn;
        }

        public Meal GetRandomMeal()
        {
            Random rnd = new Random();
            int rndMeal = rnd.Next(0, meals.Length);
            return meals[rndMeal];

        }
    }
}
    

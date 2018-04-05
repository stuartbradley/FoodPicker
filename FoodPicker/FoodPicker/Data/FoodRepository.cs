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
                Name = "cumberland Pie",
                Ingredients = new Ingredient[]
                {
                    new Ingredient() {Name = "Cumberland Pie ready meal"}
                }
            }, 
            new Meal()
            {
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
    }
}
    

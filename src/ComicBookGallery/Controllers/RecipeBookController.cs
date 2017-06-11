using RecipeBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RecipeBookGallery.Controllers
{
     public class RecipeBookController : Controller
    {
        public ActionResult Detail() 
        {
            var recipeBook = new RecipeBook()
            {
                RecipeId = 10111,
                RecipeTitle = "How to Make Pancakes",
                DescritptionHtml = "<p>How to make Chicken Biryani - Chunks of chicken, flavourful spices and long grain basmati rice layered in a handi, sealed and cooked to perfection.</p>",
                Chef = "Gordon Ramsay",
                Country = "London",
                Course = "Rice",
                Cuisine = "Hyderabadi",
                Favorite = true,
                MainIngredients = "Rice and Boneless Chicken",
                RecipeIngredients = new RecipeIngredient[] 
                {
                    new RecipeIngredient() {Ingredient = "Boneless chicken", Quantity = "600 Grams"},
                    new RecipeIngredient() {Ingredient = "Basmati rice", Quantity = "1 1/2 cups"},
                    new RecipeIngredient() {Ingredient = "Oil", Quantity = "3 tablespoons"},
                    new RecipeIngredient() {Ingredient = "Cinnamon", Quantity = "1 inch stick"},
                    new RecipeIngredient() {Ingredient = "Bay leaves", Quantity = "2"},
                    new RecipeIngredient() {Ingredient = "Green cardamom", Quantity = "5"},
                    new RecipeIngredient() {Ingredient = "Onions", Quantity = "2"},
                    new RecipeIngredient() {Ingredient = "Green Chillies", Quantity = "3"},
                    new RecipeIngredient() {Ingredient = "Turmeric Powder", Quantity = "1/4 teaspoon"},
                    new RecipeIngredient() {Ingredient = "Yogurt", Quantity = "500 Grams"},
                    new RecipeIngredient() {Ingredient = "Eggs ", Quantity = "2"},
                    new RecipeIngredient() {Ingredient = "Ginger", Quantity = "15 Grams"},

                }

            };
          


            return View(recipeBook);
            
        }
    }
}
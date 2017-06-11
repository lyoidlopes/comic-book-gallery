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

            ViewBag.RecipeTitle = "How to Make Ciken Biryani";
            ViewBag.RecipieId = 101;
            ViewBag.Description = "<p>How to make Chicken Biryani - Chunks of chicken, flavourful spices and long grain basmati rice layered in a handi, sealed and cooked to perfection.</p>";
            ViewBag.RecipeInfo = new string[]
                {
            "Chef: Lyoid Lopes",
            "Country: India",
            "Course: Rice",
            "Cuisine: Hyderabadi",
            "Main Ingredients: Boneless Chicken, Basmati Rice"
                };

            return View();
            
        }
    }
}
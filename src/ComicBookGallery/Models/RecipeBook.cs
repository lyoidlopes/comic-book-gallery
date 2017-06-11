using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecipeBookGallery.Models
{
    public class RecipeBook
    {
        public int RecipeId { get; set; }
        public string RecipeTitle { get; set; }
        public string DescritptionHtml { get; set; }
        public RecipeIngredient[] RecipeIngredients { get; set; }
        public bool Favorite { get; set; }
        public string Chef { get; set; }
        public string Country { get; set; }
        public string Course { get; set; }
        public string Cuisine { get; set; }
        public string MainIngredients { get; set; }

        public string DisplayText
        {
            get
            {
                return RecipeTitle + " #" + RecipeId;
            }
        }
        // recipie-title-recipeid.jpg
        public string CoverImageFileName
        {
            get
            {
                return RecipeTitle.Replace(" ", "-").ToLower() + "-" + RecipeId + ".jpg";
            }
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecipeBookGallery.Models
{
    public class RecipeBook
    {
        public int recipeId { get; set; }
        public string RecipeTitle { get; set; }
        public string DescritptoinHtml { get; set; }
        public RecipeInfo[] RecipeInfos { get; set; }
        public bool Favorite { get; set; }

        public string DisplayText
        {
            get
            {
                return RecipeTitle + " #" + recipeId;
            }
        }
        // recipie-title-recipeid.jpg
        public string CoverImageFileName
        {
            get
            {
                return RecipeTitle.Replace(" ", "-").ToLower() + "-" + recipeId + ".jpg";
            }
        }

    }
}
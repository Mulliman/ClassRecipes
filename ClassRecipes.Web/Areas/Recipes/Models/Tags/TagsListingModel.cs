using ClassRecipes.Core;
using System.Collections.Generic;

namespace ClassRecipes.Web.Areas.Recipes.Models.Tags
{
    public class TagsListingModel
    {
        public string Tag { get; set; }

        public IEnumerable<Recipe> Recipes { get; set; }
    }
}
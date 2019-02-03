using ClassRecipes.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassRecipes.Web.Areas.Recipes.Models
{
    public class HomePageModel
    {
        public string HeroImage { get; internal set; }

        public IEnumerable<HomeRow> Rows { get; set; }
    }
    
    public class HomeRow
    {
        public string Title { get; set; }
        
        public IEnumerable<IRelatedRecipe> Recipes { get; set; }

        public string LinkText { get; set; }

        public string LinkUrl { get; set; }
    }
}

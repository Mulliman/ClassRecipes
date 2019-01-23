using ClassRecipes.Core.Alerts;
using ClassRecipes.Core.Quantities;
using System.Collections.Generic;

namespace ClassRecipes.Core
{
    public class Step
    {        
        public string Title { get; set; }

        public IEnumerable<IQuantity<Ingredient>> Ingredients { get; set; }

        public IEnumerable<IQuantity<Tool>> Tools { get; set; }

        public IEnumerable<string> TextLines { get; set; }

        public IEnumerable<Alert> Alerts { get; set; }

        public string ImageUrl { get; set; }
    }
}

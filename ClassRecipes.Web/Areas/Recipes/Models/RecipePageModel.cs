using System.Linq;
using ClassRecipes.Core;
using ClassRecipes.Web.Areas.Common.Models;

namespace ClassRecipes.Web.Areas.Recipes.Models
{
    public class RecipePageModel
    {
        public RecipePageModel(Recipe recipe)
        {
            Recipe = recipe;
        }

        public Recipe Recipe { get; set; }

        public CollectionWithHeaderModel IngredientsCollection => new CollectionWithHeaderModel
        {
            Header = "Ingredients",
            Items = Recipe.Ingredients.Select(i => new CollectionItemModel(i.GetCorrectSingularOrPlural(), i.GetQuantityLabel()))
        };

        public CollectionWithHeaderModel ToolsCollection => new CollectionWithHeaderModel
        {
            Header = "Equipment",
            Items = Recipe.Tools.Select(i => new CollectionItemModel(i.GetCorrectSingularOrPlural(), i.GetQuantityLabel()))
        };

        public bool IsLastStep(int currentStepNumber)
        {
            return (currentStepNumber) >= Recipe.Steps.Count;
        }
    }
}

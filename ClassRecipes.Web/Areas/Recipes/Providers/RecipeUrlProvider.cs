using ClassRecipes.Core;
using ClassRecipes.Core.Providers;

namespace ClassRecipes.Web.Areas.Recipes.Providers
{
    public class RecipeUrlProvider : IRecipeUrlProvider
    {
        private const string RootUrl = "/recipe/";

        public string GetRecipeUrl(Recipe recipe)
        {
            return RootUrl + recipe.UrlName;
        }

        public string GetRecipeUrl(string recipeAlias)
        {
            return RootUrl + recipeAlias;
        }
    }
}
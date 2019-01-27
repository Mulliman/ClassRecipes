namespace ClassRecipes.Core.Providers
{
    public interface IRecipeUrlProvider
    {
        string GetRecipeUrl(Recipe recipe);

        string GetRecipeUrl(string recipeAlias);
    }
}
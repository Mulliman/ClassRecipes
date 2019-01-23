using System.Collections.Generic;
using System.Linq;

namespace ClassRecipes.Core.Repository
{
    public interface IRecipeRepository
    {
        Recipe GetRecipeFromAlias(string alias);
    }

    public class RecipeRepository : IRecipeRepository
    {
        private readonly IDictionary<string, Recipe> _recipes;

        public RecipeRepository(IEnumerable<Recipe> recipes)
        {
            _recipes = recipes.Where(r => r != null).ToDictionary(r => r.UrlName.ToLower(), r => r);
        }

        public Recipe GetRecipeFromAlias(string alias)
        {
            if(alias == null)
            {
                return null;
            }

            var loweredAlias = alias.ToLower();

            if(!_recipes.ContainsKey(loweredAlias))
            {
                return null;
            }

            return _recipes[loweredAlias];
        }
    }
}
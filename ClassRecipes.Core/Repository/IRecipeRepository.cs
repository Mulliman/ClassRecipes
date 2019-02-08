using System.Collections.Generic;
using System.Linq;

namespace ClassRecipes.Core.Repository
{
    public interface IRecipeRepository
    {
        Recipe GetRecipeFromAlias(string alias);

        IEnumerable<Recipe> GetRecipeWithTag(string tag);
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

        public IEnumerable<Recipe> GetRecipeWithTag(string tag)
        {
            if (tag == null)
            {
                return null;
            }

            var loweredAlias = tag.ToLower();

            return _recipes.Where(r => r.Value.Tags.Select(t => t.Id.ToLower()).Contains(tag)).Select(r => r.Value);
        }
    }
}
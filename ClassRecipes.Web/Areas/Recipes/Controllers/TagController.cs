using ClassRecipes.Core.Repository;
using ClassRecipes.Web.Areas.Recipes.Models.Tags;
using Microsoft.AspNetCore.Mvc;

namespace ClassRecipes.Web.Areas.Recipes.Controllers
{
    [Area("Recipes")]
    public class TagController : Controller
    {
        private readonly IRecipeRepository _repo;

        public TagController(IRecipeRepository repo)
        {
            _repo = repo;
        }

        [Route("tag/{tagId}")]
        public IActionResult TagResults(string tagId)
        {
            var matchingRecipes = _repo.GetRecipeWithTag(tagId);

            var model = new TagsListingModel
            {
                Recipes = matchingRecipes,
                Tag = tagId
            };

            return View(model);
        }
    }
}
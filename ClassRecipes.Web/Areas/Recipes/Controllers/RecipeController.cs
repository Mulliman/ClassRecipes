using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassRecipes.Core.Repository;
using ClassRecipes.Web.Areas.Recipes.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClassRecipes.Web.Areas.Recipes.Controllers
{
    [Area("Recipes")]
    public class RecipeController : Controller
    {
        private readonly IRecipeRepository _repo;

        public RecipeController(IRecipeRepository repo)
        {
            _repo = repo;
        }

        [Route("recipe/{alias}")]
        public IActionResult Index(string alias)
        {
            var recipe = _repo.GetRecipeFromAlias(alias);

            if(recipe == null)
            {
                return NotFound();
            }

            var viewModel = new RecipePageModel(recipe);

            return View("Recipe", viewModel);
        }
    }
}
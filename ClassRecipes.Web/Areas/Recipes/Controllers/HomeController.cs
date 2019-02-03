using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassRecipes.Core;
using ClassRecipes.Recipes.Cakes;
using ClassRecipes.Recipes.Lasagne;
using ClassRecipes.Web.Areas.Recipes.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClassRecipes.Web.Areas.Recipes.Controllers
{
    [Area("Recipes")]
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Home()
        {
            var model = new HomePageModel
            {
                HeroImage = "chilli-cake.jpg",
                Rows = new[]
                {
                    new HomeRow
                    {
                        Title = "Example Row",
                        Recipes = new Recipe[] { new ChilliChocolateMiniCakes(), new TurkeyAndButternutSquashLasagne() }
                    },
                    new HomeRow
                    {
                        Title = "Example Row",
                        Recipes = new Recipe[] {  new TurkeyAndButternutSquashLasagne(), new ChilliChocolateMiniCakes(), }
                    }
                }
            };

            return View(model);
        }
    }
}
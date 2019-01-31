using Microsoft.AspNetCore.Mvc;

namespace ClassRecipes.Web.Areas.Recipes.Controllers
{
    [Area("Recipes")]
    public class TagController : Controller
    {
        [Route("tag/{tagId}")]
        public IActionResult TagResults(string tagId)
        {
            return View();
        }
    }
}
using ClassRecipes.Core;
using ClassRecipes.Core.Providers;

namespace ClassRecipes.Web.Areas.Recipes.Providers
{
    public class DefaultImageUrlProvider : IImageUrlProvider
    {
        private const string RootUrl = "/img/";

        public string GetImageUrl(string imagePath)
        {
            return RootUrl + imagePath;
        }
    }
}
using ClassRecipes.Core.Providers;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace ClassRecipes.Web
{
    public static class RecipeHtmlHelpers
    {
        public static IRecipeUrlProvider RecipeUrlProvider { get; set; }
        public static IImageUrlProvider ImageUrlProvider { get; set; }

        public static HtmlString RecipeImage(this IHtmlHelper helper, string imagePath, string alt, string css)
        {
            var imageUrl = ImageUrlProvider.GetImageUrl(imagePath);

            var markup = string.IsNullOrEmpty(css)
                ? $"<img src=\"{imageUrl}\" alt=\"{alt}\" />"
                : $"<img src=\"{imageUrl}\" alt=\"{alt}\" class=\"{css}\" />";

            return new HtmlString(markup);
        }
    }
}
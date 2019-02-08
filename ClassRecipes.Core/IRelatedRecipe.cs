namespace ClassRecipes.Core
{
    public interface IRelatedRecipe
    {
        string Title { get; }

        string UrlName { get;  }

        string ShortIntro { get; }

        string ThumbnailImage { get; }

        string ThinImage { get; }
    }
}
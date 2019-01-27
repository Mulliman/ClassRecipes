namespace ClassRecipes.Core
{
    public interface IRelatedRecipe
    {
        string Title { get; }

        string UrlName { get;  }

        string ShortIntro { get; }

        string ThinImage { get; }
    }
}
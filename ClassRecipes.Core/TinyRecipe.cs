namespace ClassRecipes.Core
{
    public abstract class TinyRecipe : IRelatedRecipe
    {
        public abstract string Title { get; }

        public abstract string ShortIntro { get; }

        public virtual string ThinImage { get; }

        public virtual string ThumbnailImage { get; }

        // Tiny recipes never have their own page.
        public string UrlName => null;
    }
}
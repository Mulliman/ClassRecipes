namespace ClassRecipes.Core
{
    public abstract class TinyRecipe : IRelatedRecipe
    {
        public abstract string Title { get; }

        public abstract string ShortIntro { get; }

        public abstract string ThinImage { get; }
    }
}
using ClassRecipes.Core.Quantities;
using System;
using System.Collections.Generic;

namespace ClassRecipes.Core
{
    public abstract class Recipe : IRelatedRecipe
    {
        public abstract string Title { get; }

        public abstract string UrlName { get; }

        public abstract string Intro { get; }

        public abstract string ShortIntro { get; }

        public abstract IEnumerable<Tag> Tags { get; }

        public virtual string ThinImage { get; }

        public abstract Difficulty Difficulty { get; }

        public abstract TimeSpan CookTime { get; }

        public abstract TimeSpan PrepTime { get; }

        public abstract TimeSpan TotalTime { get; }

        public abstract IEnumerable<IQuantity<Ingredient>> Ingredients { get; }

        public abstract IEnumerable<IQuantity<Tool>> Tools { get; }

        public abstract IList<Step> Steps { get; }

        public virtual IEnumerable<string> FinishingImagePaths { get; }

        public virtual IEnumerable<IRelatedRecipe> RelatedFinishingRecipes { get; }

        public virtual string BackgroundImagePath { get; }

        public virtual IEnumerable<string> StorageInstructions { get; }
    }
}
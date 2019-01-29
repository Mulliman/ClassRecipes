using ClassRecipes.Core.Quantities;
using System;
using System.Collections.Generic;

namespace ClassRecipes.Core
{
    public abstract class Recipe : IRelatedRecipe
    {
        public string Title { get; set; }

        public string UrlName { get; set; }

        public string Intro { get; set; }

        public string ShortIntro { get; set; }

        public string ThinImage { get; set; }

        public Difficulty Difficulty { get; set; }

        public TimeSpan CookTime { get; set; }

        public TimeSpan PrepTime { get; set; }

        public TimeSpan TotalTime { get; set; }

        public IEnumerable<IQuantity<Ingredient>> Ingredients { get; set; }

        public IEnumerable<IQuantity<Tool>> Tools { get; set; }

        public IList<Step> Steps { get; set; }

        public IEnumerable<string> FinishingImagePath { get; set; }

        public IEnumerable<IRelatedRecipe> RelatedFinishingRecipes { get; set; }

        public string BackgroundImagePath { get; set; }
    }
}
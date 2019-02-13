using ClassRecipes.Core;
using ClassRecipes.Core.Alerts;
using ClassRecipes.Core.Quantities;
using ClassRecipes.Ingredients;
using ClassRecipes.Tags;
using ClassRecipes.Tools;
using System;
using System.Collections.Generic;

namespace ClassRecipes.Recipes.Pizze
{
    public class SimplePizzaDough : Recipe
    {
        protected static IQuantity<Ingredient> Flour = new Quantity<Ingredient>(Flours.DoubleZeroFlour, 300, Units.Gram);
        protected static IQuantity<Ingredient> Water = new Quantity<Ingredient>(Waters.WarmWater, 200, Units.Millilitre);
        protected static IQuantity<Ingredient> Salt = new Quantity<Ingredient>(Salts.Salt, 1, Units.Teaspoon);
        protected static IQuantity<Ingredient> Sugar = new Quantity<Ingredient>(Sugars.DarkBrownSugar, 1, Units.Teaspoon);
        protected static IQuantity<Ingredient> OliveOil = new Quantity<Ingredient>(Oils.ExtraVirginOliveOil, 1, Units.Tablespoon);
        protected static IQuantity<Ingredient> Yeast = new Quantity<Ingredient>(Baking.Yeast, 7, Units.Gram);

        protected Step ActivateYeast = new Step
        {
            Title = "Activate Yeast",
            Tools = new[] { new NoQuantity<Tool>(BowlsAndJugs.MeasuringJug) },
            Ingredients = new[] { Water, Yeast, Sugar },
            TextLines = new[] { "Add the yeast and sugar to the water and leave for 5 minutes." }
        };

        protected Step MixDryIngredients = new Step
        {
            Title = "Mix Dry Ingredients",
            Tools = new[] { new NoQuantity<Tool>(BowlsAndJugs.MixingBowl) },
            Ingredients = new[] { Flour, Salt },
            TextLines = new[] { "Mix the salt into sifted flour." }
        };

        protected Step Combine = new Step
        {
            Title = "Combine",
            Ingredients = new[] { OliveOil },
            TextLines = new[] 
            {
                "Create a well in the middle of the flour. Add the yeast water and olive oil and stir until combined.",
                "Once combined remove the dough from the bowl and knead on a worktop for 10 minutes."
            }
        };

        protected Step Prove = new Step
        {
            Title = "Prove",
            TextLines = new[]
            {
                "Coat the mixing bowl with a little more oil and add the dough back in. Cover with cling film or a tea towel and let the dough rise for at least 2 hours, the longer the better."
            }
        };

        protected Step PreheatOven = new Step
        {
            Title = "Preheat Oven",
            TextLines = new[]
            {
                "Preate the oven to the hottest temperature, ideally 250C or above.",
                "Make sure that the pizza stone, cast iron skillet or baking sheet you will cook on is also in the oven to preheat."
            }
        };

        protected Step ShapeDough = new Step
        {
            Title = "Shape Dough",
            TextLines = new[]
            {
                "Remove the dough from the bowl and place on a lightly floured worktop.",
                "Using your fingers push down the centre of the dough, and then stretch the dough until you can see through it when help up to the light.",
            },
            Alerts = new[] { new InfoAlert("If you struggle with stretching the dough you can use a rolling pin, however you won't get as much rise on the crust.") }
        };

        protected Step AddIngredientsAndCook = new Step
        {
            Title = "Add ingredient",
            TextLines = new[]
            {
                "Add all your desired ingredients to the pizza and transfer to the oven.",
                "Cook until the cheese is melted and the crust is golden. This should take between 5 and 10 minutes depending on the oven temperature.",
            }
        };

        public override string Title => "Simple Pizza Dough";

        public override string UrlName => "simple-pizza-dough";

        public override string Intro => "Simple pizza dough suitable for italian style pizzas.";

        public override string ShortIntro => "Simple pizza dough suitable for italian style pizzas.";

        public override IEnumerable<Tag> Tags => new[] { ReusableTags.Italian, ReusableTags.Pizza };

        public override Difficulty Difficulty => Difficulty.Easy;

        public override TimeSpan CookTime => new TimeSpan(0, 10, 0);

        public override TimeSpan PrepTime => new TimeSpan(5, 0, 0);

        public override TimeSpan TotalTime => new TimeSpan(5, 10, 0);

        public override IEnumerable<IQuantity<Ingredient>> Ingredients => new[] { Flour, Water, Salt, Sugar, OliveOil, Yeast };

        public override IEnumerable<IQuantity<Tool>> Tools => new[] { new NoQuantity<Tool>(BowlsAndJugs.MeasuringJug), new NoQuantity<Tool>(BowlsAndJugs.MixingBowl) };

        public override IList<Step> Steps => new[] { ActivateYeast, MixDryIngredients, Combine, Prove, PreheatOven, ShapeDough, AddIngredientsAndCook };

        public override int AmountOfPortions => 2;
    }
}

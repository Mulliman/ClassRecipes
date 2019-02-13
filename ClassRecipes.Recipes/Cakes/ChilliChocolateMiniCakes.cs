using System;
using System.Collections.Generic;
using ClassRecipes.Core;
using ClassRecipes.Core.Alerts;
using ClassRecipes.Core.Quantities;
using ClassRecipes.Ingredients;
using ClassRecipes.Recipes.TinyRecipes.Chilli;
using ClassRecipes.Tags;
using ClassRecipes.Tools;

namespace ClassRecipes.Recipes.Cakes
{
    public class ChilliChocolateMiniCakes : Recipe
    {
        private readonly Quantity<Ingredient> _choc = new Quantity<Ingredient>(Chocolates.DarkChocolate, 250, Units.Gram);
        private readonly Quantity<Ingredient> _butter = new Quantity<Ingredient>(Dairy.UnsaltedButter, 250, Units.Gram);
        private readonly Quantity<Ingredient> _coffee = new Quantity<Ingredient>(Coffees.InstantCoffee, 1, Units.Teaspoon);
        private readonly Quantity<Ingredient> _water = new Quantity<Ingredient>(new Ingredient("Boiling Water"), 125, Units.Millilitre);
        private readonly Quantity<Ingredient> _cocoa = new Quantity<Ingredient>(Chocolates.CocoaPowder, 50, Units.Gram);
        private readonly Quantity<Ingredient> _flour = new Quantity<Ingredient>(Flours.PlainFlour, 200, Units.Gram);
        private readonly Quantity<Ingredient> _bakingPowder = new Quantity<Ingredient>(Baking.BakingPowder, 1.5, Units.Teaspoon);
        private readonly Quantity<Ingredient> _bakingSoda = new Quantity<Ingredient>(Baking.BakingSoda, 0.5, Units.Teaspoon);
        private readonly Quantity<Ingredient> _sugar = new Quantity<Ingredient>(Sugars.CasterSugar, 250, Units.Gram);
        private readonly Quantity<Ingredient> _brownSugar = new Quantity<Ingredient>(Sugars.LightBrownSugar, 250, Units.Gram);
        private readonly Quantity<Ingredient> _eggs = new Quantity<Ingredient>(Eggs.LargeEggs, 4);
        private readonly Quantity<Ingredient> _milk = new Quantity<Ingredient>(Dairy.FullFatMilk, 100, Units.Millilitre);
        private readonly Quantity<Ingredient> _lemonJuice = new Quantity<Ingredient>(Juices.LemonJuice, 2, Units.Tablespoon);
        private readonly RangeQuantity<Ingredient> _chilli = new RangeQuantity<Ingredient>(Peppers.SmallDriedChilliPepper, 1, 3);
        private readonly Quantity<Ingredient> _clementine = new Quantity<Ingredient>(Fruits.Clementine, 1);

        public ChilliChocolateMiniCakes()
        {       
        }

        public override string Title => "Chilli Chocolate Mini Cakes";

        public override string UrlName => "chilli-chocolate-mini-cakes";

        public override string Intro => @"An adult chocolate cake for those that don't want to believe that 'adult' food must include alcohol,
this cake has a slightly spicy, smoky after taste and a deep moist chocolatey flavour.";

        public override string ShortIntro => "An adult chocolate cake for those that don't want to believe that 'adult' food must include alcohol.";

        public override IEnumerable<Tag> Tags => new[] { ReusableTags.Baking, ReusableTags.Cake, ReusableTags.Chocolate, ReusableTags.Chilli, ReusableTags.Spicy };

        public override Difficulty Difficulty => Difficulty.Medium;

        public override TimeSpan CookTime => new System.TimeSpan(0, 40, 0);

        public override TimeSpan PrepTime => new System.TimeSpan(0, 30, 0);

        public override TimeSpan TotalTime => new System.TimeSpan(1, 20, 0);

        public override IEnumerable<IQuantity<Ingredient>> Ingredients => new IQuantity<Ingredient>[]
            {
                _choc, _butter, _coffee, _water, _cocoa, _flour, _bakingPowder, _bakingSoda, _sugar, _brownSugar, _eggs, _milk, _lemonJuice, _chilli, _clementine
            };

        public override IEnumerable<IQuantity<Tool>> Tools => new IQuantity<Tool>[]
            {
                new NoQuantity<Tool>(Appliances.Oven),
                new NoQuantity<Tool>(Appliances.Hob),
                new Quantity<Tool>(BakingTools.BakingPan8Inch, 2),
                new Quantity<Tool>(BowlsAndJugs.MixingBowl, 3),
                new NoQuantity<Tool>(Pans.Saucepan),
                new NoQuantity<Tool>(PapersAndWraps.BakingPaper),
                new NoQuantity<Tool>(Misc.MortarAndPestle),
                new NoQuantity<Tool>(Misc.Grater),
                new NoQuantity<Tool>(BakingTools.WireRack),
            };

        public override IList<Step> Steps => new[]
            {
                new Step
                {
                    Title = "Make Fake Buttermilk",
                    TextLines = new []
                    {
                        "Mix the milk and lemon juice and stir well. This is an easy alternative to butter milk.",
                        "The liquid will likely curdle, but this isn't a problem."
                    },
                    Ingredients = new [] { _milk, _lemonJuice },
                    Tools = new [] { new Quantity<Tool>(BowlsAndJugs.MixingBowl, 3) }
                },
                new Step
                {
                    Title = "Preheat Oven",
                    TextLines = new []
                    {
                        "Preheat oven to 160C or 140C Fan."
                    },
                    Tools = new [] { new NoQuantity<Tool>(Appliances.Oven) }
                },
                new Step
                {
                    Title = "Line Baking Tins",
                    TextLines = new []
                    {
                        "Line 2 baking tins with baking paper."
                    },
                    Tools = new IQuantity<Tool>[] { new Quantity<Tool>(BakingTools.BakingPan8Inch, 2), new NoQuantity<Tool>(PapersAndWraps.BakingPaper) }
                },
                new Step
                {
                    Title = "Melt Butter and Chocolate",
                    TextLines = new []
                    {
                        "Bring some water to simmer in a saucepan and then put the mixing bowl on top. This is called a Bain-marie.",
                        "Heat up the chocolate and butter until melted."
                    },
                    Tools = new IQuantity<Tool>[] { new Quantity<Tool>(BowlsAndJugs.MixingBowl, 1), new NoQuantity<Tool>(Pans.Saucepan),},
                    Ingredients = new [] { _choc, _butter }
                },
                new Step
                {
                    Title = "Add Coffee",
                    TextLines = new []
                    {
                        "Combine the coffee and boiling water, and then add to the butter and chocolate mix.",
                        "Stir until fully combined and then remove from the heat."
                    },
                    Ingredients = new [] { _coffee, _water }
                },
                new Step
                {
                    Title = "Mix Dry Ingredients",
                    TextLines = new []
                    {
                        "Combine the dry ingredients listed in this step and mix well."
                    },
                    Tools = new IQuantity<Tool>[] { new Quantity<Tool>(BowlsAndJugs.MixingBowl, 1)},
                    Ingredients = new [] { _cocoa, _flour, _bakingPowder, _bakingSoda, _sugar, _brownSugar }
                },
                new Step
                {
                    Title = "Add Eggs",
                    TextLines = new []
                    {
                        "Add the eggs to the milky mixture from step 0. Mix until combined."
                    },
                    Ingredients = new [] { _eggs }
                },
                new Step
                {
                    Title = "Combine Ingredients",
                    TextLines = new []
                    {
                        "Add both the wet mix and the chocolate mix to the dry ingredients.",
                        "Combine well, but don't overmix or overwhisk. We are not trying to whisk air into this mixture."
                    },
                    Ingredients = new []
                    {
                        new NoQuantity<Ingredient>(new Ingredient("Wet Ingredients Mix")),
                        new NoQuantity<Ingredient>(new Ingredient("Dry Ingredients Mix")),
                        new NoQuantity<Ingredient>(new Ingredient("Chocolate and Butter Mix"))
                    }
                },
                new Step
                {
                    Title = "Prepare Chillies",
                    TextLines = new []
                    {
                        "Slice open the dried chillies and remove the seeds.",
                        "Finely dice the chillies and add to the mortar.",
                        "Use the pestle to grind the chillies to a fine powder.",
                        "Add the powder to the cake mix and stir until well combined."
                    },
                    Ingredients = new [] { _chilli },
                    Tools = new [] { new NoQuantity<Tool>(Misc.MortarAndPestle) },
                    Alerts = new []
                    {
                        new InfoAlert("It's very important to add the chillies gradually and taste at this stage! I found my chillies were too mild, so I also added 2tsp of Cayennne Pepper.")
                    }
                },
                new Step
                {
                    Title = "Prepare Clementine",
                    TextLines = new []
                    {
                        "Grate the zest of the clementine into the cake mix and then cut the clementine in half and sqeeze the juice in there too.",
                        "Give the mix one final stir."
                    },
                    Ingredients = new [] { _clementine },
                    Tools = new [] { new NoQuantity<Tool>(Misc.Grater) }
                },
                new Step
                {
                    Title = "Bake",
                    TextLines = new []
                    {
                        "Equally divide the mixture into the two baking pans and put in the middle of the preheated oven.",
                        "Cook for 45 minutes and then check if a toothpick comes out clean when poked into the middle of the cake.If the toothpick isn't clean keep testing at 5 minute intervals."
                    },
                    Ingredients = new [] { _clementine },
                    Tools = new IQuantity<Tool>[] { new NoQuantity<Tool>(Appliances.Oven), new Quantity<Tool>(BakingTools.BakingPan8Inch, 2) }
                }
            };

        public override IEnumerable<string> FinishingImagePaths => new[] { "chilli-cake.jpg" };

        public override string BackgroundImagePath => "chilli-cake-2.jpg";

        public override IEnumerable<IRelatedRecipe> RelatedFinishingRecipes => new IRelatedRecipe[] { new CayenneChocolateButtercreamTinyRecipe(), new ChilliSyrupTinyRecipe() };

        public override int AmountOfPortions => 30;
    }
}
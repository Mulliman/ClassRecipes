using ClassRecipes.Core;
using ClassRecipes.Core.Alerts;
using ClassRecipes.Core.Quantities;
using ClassRecipes.Ingredients;
using ClassRecipes.Ingredients.Meats;
using ClassRecipes.Tools;
using System;
using System.Collections.Generic;

namespace ClassRecipes.Recipes.Lasagne
{
    public class TurkeyAndButternutSquashLasagne : Recipe
    {
        private Quantity<Ingredient> _butternut = new Quantity<Ingredient>(Vegetables.ButternutSquash, 0.5);
        private Quantity<Ingredient> _carrot = new Quantity<Ingredient>(Vegetables.Carrot, 1);
        private Quantity<Ingredient> _onion = new Quantity<Ingredient>(Vegetables.Onion, 1);
        private Quantity<Ingredient> _tomatoes = new Quantity<Ingredient>(Tomatoes.Passata, 500, Units.Millilitre);
        private Quantity<Ingredient> _basil = new Quantity<Ingredient>(Herbs.DriedBasil, 1, Units.Tablespoon);
        private Quantity<Ingredient> _oregano = new Quantity<Ingredient>(Herbs.DriedOregano, 1, Units.Tablespoon);
        private Quantity<Ingredient> _garlic = new Quantity<Ingredient>(Herbs.GarlicPowder, 1, Units.Tablespoon);
        private Quantity<Ingredient> _oliveOil = new Quantity<Ingredient>(Oils.OliveOil, 1, Units.Tablespoon);
        private Quantity<Ingredient> _turkeyMince = new Quantity<Ingredient>(Turkey.TurkeyMince, 500, Units.Gram);
        private Quantity<Ingredient> _parmesan = new Quantity<Ingredient>(Cheeses.GranaPadano, 100, Units.Gram);
        private Quantity<Ingredient> _mozzerella = new Quantity<Ingredient>(Cheeses.Mozzarella, 125, Units.Gram);
        private Quantity<Ingredient> _greekYog = new Quantity<Ingredient>(Dairy.GreekYoghurt, 125, Units.Millilitre);

        public override string Title => "One Pan Turkey and Butternut Squash 'Lasagne'";

        public override string UrlName => "turkey-butternut-squash-lasagne";

        public override string Intro => "While not authenic in any way, this one pan vegetable lasagne is an easy way to sneak two of your five a day in.";

        public override string ShortIntro => "While not authenic in any way, this one pan vegetable lasagne is an easy way to sneak two of your five a day in.";

        public override Difficulty Difficulty => Difficulty.Medium;

        public override TimeSpan CookTime => new TimeSpan(0,30,0);

        public override TimeSpan PrepTime => new TimeSpan(0, 30, 0);

        public override TimeSpan TotalTime => new TimeSpan(1, 0, 0);

        public override IEnumerable<IQuantity<Ingredient>> Ingredients => new[]
        {
            _butternut, _carrot, _onion, _tomatoes, _basil, _oregano, _garlic, _oliveOil, _turkeyMince
        };

        public override IEnumerable<IQuantity<Tool>> Tools => new IQuantity<Tool>[]
        {
            new NoQuantity<Tool>(Appliances.Hob),
            new NoQuantity<Tool>(Appliances.Oven),
            new NoQuantity<Tool>(Pans.FryingPan)
        };

        public override IList<Step> Steps => new List<Step>
        {
            new Step
            {
                Title = "Preheat Oven",
                TextLines = new [] { "Preheat the oven to 200C" },
                Tools = new IQuantity<Tool>[]
                {
                    new NoQuantity<Tool>(Appliances.Oven)
                }
            },
            new Step
            {
                Title = "Chop Veg",
                Ingredients = new [] { _onion, _carrot, _butternut },
                TextLines = new [] 
                {
                    "Peel the butternut squash and slice into thin slices. Peel and finely dice the onion and carrot."
                },
                Alerts = new[]
                {
                    new InfoAlert("To get a very fine choped carrot try using a grater, or a peeler to create fine ribbons and then dice those.")
                }
            },
            new Step
            {
                Title = "Fry Veg and Mince",
                Ingredients = new [] { _onion, _carrot, _turkeyMince, _oliveOil },
                TextLines = new []
                {
                    "Fry the onion, carrot and mince in a small amount of olive oil over a medium high heat until the turkey mince is no longer pink."
                },
                Tools = new IQuantity<Tool>[]
                {
                    new NoQuantity<Tool>(Appliances.Hob),
                    new NoQuantity<Tool>(Pans.FryingPan)
                }
            },
            new Step
            {
                Title = "Add tomatoes and herbs",
                Ingredients = new [] { _tomatoes, _basil, _oregano, _garlic },
                TextLines = new []
                {
                    "Add the passata, herbs and garlic to the pan and stir until combined.",
                    "Cook for 5-10 minutes to reduce a bit."
                }
            },
            new Step
            {
                Title = "Add squash",
                Ingredients = new [] { _butternut },
                TextLines = new []
                {
                    "Add the butternut squash in layers and push down into the sauce."
                }
            },
            new Step
            {
                Title = "Add dairy",
                Ingredients = new [] { _greekYog, _mozzerella, _parmesan },
                TextLines = new []
                {
                    "Evenly spread the greek yoghurt over the top of the mince and squash, tear mozzarella and scatter and then finally sprinkle grated hard cheese on top."
                }
            },
            new Step
            {
                Title = "Bake",
                Tools = new [] { new NoQuantity<Tool>(Appliances.Oven)},
                TextLines = new []
                {
                    "Put in the oven and cook for 30 minutes.",
                },
                Alerts = new Alert[] 
                {
                    new InfoAlert("For even better results, grill the 'lasagne' for 2-5 minutes at the end of the cooking")
                }
            }
        };

        public override IEnumerable<string> StorageInstructions => new[]
        {
            "Refrigerate any leftovers in a sealed container and eat within 3 days. Reheat at full power (900w) in the microwave for 2-3 minutes. Make sure that the leftovers are hot all the way through."
        };
    }
}
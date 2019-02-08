using ClassRecipes.Core;
using ClassRecipes.Core.Quantities;
using ClassRecipes.Ingredients;
using ClassRecipes.Tags;
using ClassRecipes.Tools;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRecipes.Recipes.Potatoes
{
    class AlmostAsGoodAsFriedOvenChips : Recipe
    {
        private IQuantity<Ingredient> _potato = new Quantity<Ingredient>(Vegetables.MarisPiperPotato, 500, Units.Gram);
        private IQuantity<Ingredient> _cornflour = new Quantity<Ingredient>(Flours.Cornflour, 1, Units.HeapedTablespoon);
        private IQuantity<Ingredient> _paprika = new Quantity<Ingredient>(Spices.SmokedPaprika, 1, Units.Teaspoon);
        private IQuantity<Ingredient> _cayenne = new Quantity<Ingredient>(Spices.CayennePepper, 0.5, Units.Teaspoon);
        private IQuantity<Ingredient> _pepper = new Quantity<Ingredient>(Peppers.BlackPepper, 0.5, Units.Teaspoon);
        private IQuantity<Ingredient> _oil = new Quantity<Ingredient>(Oils.VegetableOil, 4, Units.Tablespoon);
        private IQuantity<Ingredient> _vinegar = new Quantity<Ingredient>(Vinegars.Vinegar, 1, Units.Tablespoon);
        private IQuantity<Ingredient> _salt = new Quantity<Ingredient>(Salts.Salt, 1, Units.Tablespoon);

        public override string Title => "Almost as Good as Fried Oven Chips";

        public override string UrlName => "almost-as-good-as-fried-oven-chips";

        public override string Intro => "Deep frying is the best way to make chips, but this oven baked recipes is a bout as close as you'll get.";

        public override string ShortIntro => "Deep frying is the best way to make chips, but this oven baked recipes is a bout as close as you'll get.";

        public override IEnumerable<Tag> Tags => new[] { ReusableTags.Potatoes, ReusableTags.Chips, ReusableTags.Fries, ReusableTags.Baked };

        public override Difficulty Difficulty => Difficulty.Easy;

        public override TimeSpan CookTime => new TimeSpan(0, 30, 0);

        public override TimeSpan PrepTime => new TimeSpan(0, 30, 0);

        public override TimeSpan TotalTime => new TimeSpan(1, 0, 0);

        public override IEnumerable<IQuantity<Ingredient>> Ingredients => new IQuantity<Ingredient>[]
        {
            _potato, _cornflour, _paprika, _cayenne, _pepper, _oil, _vinegar, _salt
        };

        public override IEnumerable<IQuantity<Tool>> Tools => new IQuantity<Tool>[]
        {
            new NoQuantity<Tool>(Appliances.Oven),
            new NoQuantity<Tool>(Appliances.Hob),
            new NoQuantity<Tool>(Pans.Saucepan),
            new NoQuantity<Tool>(BakingTools.BakingSheet),
            new NoQuantity<Tool>(PapersAndWraps.PaperTowels),
            new NoQuantity<Tool>(Misc.Colander),
        };

        public override IList<Step> Steps => new[]
        {
            new Step
            {
                Title = "Preheat Oven",
                Ingredients = new [] { _oil },
                Tools = new [] { new NoQuantity<Tool>(Appliances.Oven),new NoQuantity<Tool>(BakingTools.BakingSheet) },
                TextLines = new [] { "Preheat an oven to 220c. While preheating, add the oil to a baking sheet and put in the oven to also preheat." },
            },
            new Step
            {
                Title = "Cut Potatoes",
                Ingredients = new [] { _potato },
                TextLines = new [] { "Chop the potatoes into chips roughly 1cm thick." },
            },
            new Step
            {
                Title = "Parboil Potatoes",
                Tools = new [] { new NoQuantity<Tool>(Appliances.Hob),new NoQuantity<Tool>(Pans.Saucepan) },
                Ingredients = new [] { _potato, _salt, _vinegar },
                TextLines = new [] 
                {
                    "Place the potatoes in a saucepan and cover with water. Add the salt and vinegar, cover with a lid, and bring the water to the boil on the highest heat.",
                    "Once boiling, parboil the potatoes for 5 more minutes." },
            },
            new Step
            {
                Title = "Mix Dry Ingredients",
                Ingredients = new [] { _cornflour, _paprika, _cayenne, _pepper },
                TextLines = new []
                {
                    "On a plate or in a bowl combine the dry ingredients."
                },
            },
            new Step
            {
                Title = "Dry Potatoes",
                Tools = new [] { new NoQuantity<Tool>(Misc.Colander), new NoQuantity<Tool>(PapersAndWraps.PaperTowels) },
                TextLines = new []
                {
                    "Remove the chips from the pan and let steam in a colander for a minute or so.",
                    "Dry the chips with some paper towels."
                },
            },
            new Step
            {
                Title = "Coat the potatoes",
                TextLines = new []
                {
                    "Add the chips to the dry mix and ensure that all the chips are equally coated."
                },
            },
            new Step
            {
                Title = "Put chips in oven",
                TextLines = new []
                {
                    "Add the chips to the hot oil and gently toss the chips with a spatula to ensure they are coated in oil.",
                    "Cook for 20 minutes at 220c"
                },
            },
            new Step
            {
                Title = "Turn the chips",
                TextLines = new []
                {
                    "After 20 minutes, give the chips a turn and then cook for 10-15 minutes more.",
                    "When crispy, remove from the oven and remove the excess fat from the chips by blotting with more paper towels."
                },
            }
        };
    }
}

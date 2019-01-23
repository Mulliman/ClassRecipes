using ClassRecipes.Core;

namespace ClassRecipes.Ingredients
{
    public static class Chocolates
    {
        public static Ingredient DarkChocolate = new Ingredient("Dark Chocolate");
        public static Ingredient WhiteChocolate = new Ingredient("White Chocolate");
        public static Ingredient MilkChocolate = new Ingredient("Milk Chocolate");
        public static Ingredient DarkChocolateChips = new Ingredient("Dark Chocolate Chips");
        public static Ingredient MilkChocolateChips = new Ingredient("Milk Chocolate Chips");

        public static Ingredient CocoaPowder = Baking.CocoaPowder;
    }
}
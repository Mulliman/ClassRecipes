using ClassRecipes.Core;

namespace ClassRecipes.Ingredients
{
    public static class Fruits
    {
        public static Ingredient Clementine = new Ingredient("Clementine");
        public static Ingredient Orange = new Ingredient("Orange");
        public static Ingredient Cherry = new Ingredient("Cherry", "Cherries");
    }
}
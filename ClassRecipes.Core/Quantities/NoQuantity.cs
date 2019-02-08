namespace ClassRecipes.Core.Quantities
{
    public class NoQuantity<T> : IQuantity<T> where T : IPluralisable
    {
        public NoQuantity(T item)
        {
            Item = item;
        }

        public T Item { get; set; }

        public string GetCorrectSingularOrPlural()
        {
            return Item.Singular;
        }

        public string GetQuantityLabel()
        {
            return null;
        }

        public string GetAbbreviatedLabel()
        {
            return null;
        }
    }
}
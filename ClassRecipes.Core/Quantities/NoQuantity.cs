namespace ClassRecipes.Core.Quantities
{
    public class NoQuantity<T> : IQuantity<T>
    {
        public NoQuantity(T item)
        {
            Item = item;
        }

        public T Item { get; set; }

        public string GetQuantityLabel()
        {
            return null;
        }
    }
}
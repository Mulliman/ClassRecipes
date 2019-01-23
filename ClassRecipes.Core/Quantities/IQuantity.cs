namespace ClassRecipes.Core.Quantities
{
    public interface IQuantity<T>
    {
        T Item { get; set; }

        string GetQuantityLabel();
    }
}
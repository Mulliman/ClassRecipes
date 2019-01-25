namespace ClassRecipes.Core.Quantities
{
    public interface IQuantity<T> where T : IPluralisable
    {
        T Item { get; set; }

        string GetQuantityLabel();

        string GetCorrectSingularOrPlural();
    }
}
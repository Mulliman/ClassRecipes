namespace ClassRecipes.Core.Quantities
{
    public class RangeQuantity<T> : IQuantity<T>
    {
        public RangeQuantity(T item, double lowerAmount, double higherAmount, Unit unit = null)
        {
            Item = item;
            LowerAmount = lowerAmount;
            HigherAmount = higherAmount;
            Unit = unit;
        }

        public T Item { get; set; }

        public double LowerAmount { get; set; }

        public double HigherAmount { get; set; }
        
        public Unit Unit { get; set; }

        public string GetQuantityLabel()
        {
            return $"{LowerAmount}-{HigherAmount} {Unit.Plural}";
        }
    }
}
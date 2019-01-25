namespace ClassRecipes.Core.Quantities
{
    public class RangeQuantity<T> : IQuantity<T> where T : IPluralisable
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

        public string GetCorrectSingularOrPlural()
        {
            if(Item == null)
            {
                return null;
            }

            return Item.Plural;
        }

        public string GetQuantityLabel()
        {
            return Unit == null 
                ? $"{LowerAmount}-{HigherAmount}"
                : $"{LowerAmount}-{HigherAmount} {Unit.Plural}";
        }
    }
}
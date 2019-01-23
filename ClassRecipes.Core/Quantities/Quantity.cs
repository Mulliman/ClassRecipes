namespace ClassRecipes.Core.Quantities
{

    public class Quantity<T> : IQuantity<T>
    {
        public Quantity(T item, double amount, Unit unit = null)
        {
            Item = item;
            Amount = amount;
            Unit = unit;
        }

        public T Item { get; set; }

        public double Amount { get; set; }
        
        public Unit Unit { get; set; }

        public string GetQuantityLabel()
        {
            if(Amount == 1)
            {
                return $"1 {Unit.FullName}";
            }

            return $"{Amount} {Unit.Plural}"; 
        }
    }
}
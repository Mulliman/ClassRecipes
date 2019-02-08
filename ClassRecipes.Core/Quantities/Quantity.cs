namespace ClassRecipes.Core.Quantities
{

    public class Quantity<T> : IQuantity<T> where T : IPluralisable
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

        public string GetCorrectSingularOrPlural()
        {
            return (Amount == 1 || Unit != null) ? Item?.Singular : Item?.Plural;
        }

        public string GetAbbreviatedLabel()
        {
            if (Amount == 1)
            {
                if (Unit == null)
                {
                    return "1";
                }

                return $"1 {Unit.Abbreviation}";
            }

            if (Unit == null)
            {
                return $"{Amount}";
            }

            return $"{Amount} {Unit.Abbreviation}";
        }

        public string GetQuantityLabel()
        {
            if(Amount == 1)
            {
                if (Unit == null)
                {
                    return "1";
                }

                return $"1 {Unit.FullName}";
            }

            if (Unit == null)
            {
                return $"{Amount}";
            }

            return $"{Amount} {Unit.Plural}"; 
        }
    }
}
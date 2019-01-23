namespace ClassRecipes.Core.Purchasing
{
    public abstract class BuyLink
    {
        public abstract Shop Shop { get; }

        public abstract string Link { get; }
    }
}
namespace ClassRecipes.Core.Alerts
{
    public class TipAlert : Alert
    {
        public const string Identifier = "tip";

        public TipAlert(string text) : base(text, Identifier)
        {
        }
    }
}
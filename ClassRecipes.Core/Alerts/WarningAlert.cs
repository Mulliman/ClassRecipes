namespace ClassRecipes.Core.Alerts
{
    public class WarningAlert : Alert
    {
        public const string Identifier = "warning";

        public WarningAlert(string text) : base(text, Identifier)
        {
        }
    }
}
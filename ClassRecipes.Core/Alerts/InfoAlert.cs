namespace ClassRecipes.Core.Alerts
{
    public class InfoAlert : Alert
    {
        public const string Identifier = "info";

        public InfoAlert(string text) : base(text, Identifier)
        {
        }
    }
}
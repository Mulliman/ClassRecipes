namespace ClassRecipes.Core.Alerts
{
    public abstract class Alert
    {
        public Alert(string text, string typeName)
        {
            Text = text;
            TypeName = typeName;
        }

        public string Text { get; set; }

        public string TypeName { get; set; }
    }
}
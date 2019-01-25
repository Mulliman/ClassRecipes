namespace ClassRecipes.Web.Areas.Common.Models
{
    public class CollectionItemModel
    {
        public CollectionItemModel()
        {
        }

        public CollectionItemModel(string text, string label)
        {
            Text = text;
            Label = label;
        }

        public string Text { get; set; }

        public string Label { get; set; }
    }
}
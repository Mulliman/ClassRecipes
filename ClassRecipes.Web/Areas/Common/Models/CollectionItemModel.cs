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

        public CollectionItemModel(string text, string label, string title)
        {
            Text = text;
            Label = label;
            Title = title;
        }

        public string Text { get; set; }

        public string Label { get; set; }

        public string Title { get; set; }
    }
}
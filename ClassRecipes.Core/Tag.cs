namespace ClassRecipes.Core
{
    public class Tag
    {
        public Tag(string title)
        {
            Title = title;
            Id = title.ToLower().Replace(" ", "");
        }

        public string Id { get; set; }

        public string Title { get; set; }
    }
}
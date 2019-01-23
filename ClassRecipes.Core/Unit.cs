namespace ClassRecipes.Core
{
    public class Unit
    {
        public Unit(string fullName, string abbreviation)
        {
            FullName = fullName;
            Abbreviation = abbreviation;
        }

        public string FullName { get; set; }

        public string Plural => FullName + "s";

        public string Abbreviation { get; set; }
    }
}
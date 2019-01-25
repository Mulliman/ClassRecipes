using ClassRecipes.Core.Purchasing;
using ClassRecipes.Core.Quantities;
using System.Collections.Generic;

namespace ClassRecipes.Core
{
    public class Ingredient :  IPluralisable
    {
        private string _plural;

        public Ingredient(string name, string plural = null)
        {
            Name = name;
            _plural = plural;
        }

        public Ingredient(string name, IEnumerable<BuyLink> buyLinks)
        {
            Name = name;
            BuyLinks = buyLinks;
        }

        public Ingredient(string name, string plural, IEnumerable<BuyLink> buyLinks)
        {
            Name = name;
            _plural = plural;
            BuyLinks = buyLinks;
        }

        public string Name { get; set; }

        public string Singular => Name;

        public string Plural => _plural ?? (Name + "s");

        public IEnumerable<BuyLink> BuyLinks { get; set; }
    }
}
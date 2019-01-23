using ClassRecipes.Core.Purchasing;
using System.Collections.Generic;

namespace ClassRecipes.Core
{
    public class Tool
    {
        private string _plural;

        public Tool(string name, string plural = null)
        {
            Name = name;
            _plural = plural;
        }

        public Tool(string name, IEnumerable<BuyLink> buyLinks)
        {
            Name = name;
            BuyLinks = buyLinks;
        }

        public Tool(string name, string plural, IEnumerable<BuyLink> buyLinks)
        {
            Name = name;
            _plural = plural;
            BuyLinks = buyLinks;
        }

        public string Name { get; set; }
        
        public string Plural => _plural ?? (Name + "s");

        public IEnumerable<BuyLink> BuyLinks { get; set; }
    }
}

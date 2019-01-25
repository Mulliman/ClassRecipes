using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassRecipes.Web.Areas.Common.Models
{
    public class CollectionWithHeaderModel
    {
        public string Header { get; set; }

        public IEnumerable<CollectionItemModel> Items { get; set; }
    }
}
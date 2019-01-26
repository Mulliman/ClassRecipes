using ClassRecipes.Core;
using ClassRecipes.Web.Areas.Common.Models;
using System.Collections.Generic;
using System.Linq;

namespace ClassRecipes.Web.Areas.Recipes.Models
{
    public class StepModel
    {
        public StepModel(Step step, int index, bool isLastStep)
        {
            Step = step;
            Index = index;
            IsLastStep = isLastStep;
        }

        public Step Step { get; }

        public int Index { get; }

        public bool IsLastStep { get; }

        public int NextStepIndex => Index + 1;

        public IEnumerable<CollectionItemModel> ToolItems => Step?.Tools?.Select(i => new CollectionItemModel(i.GetCorrectSingularOrPlural(), i.GetQuantityLabel()));

        public IEnumerable<CollectionItemModel> IngredientItems => Step?.Ingredients?.Select(i => new CollectionItemModel(i.GetCorrectSingularOrPlural(), i.GetQuantityLabel()));

        public IEnumerable<CollectionItemModel> ToolsAndIngredients
        {
            get
            {
                var list = new List<CollectionItemModel>();

                if(ToolItems?.Any() == true)
                {
                    list.AddRange(ToolItems);
                }

                if (IngredientItems?.Any() == true)
                {
                    list.AddRange(IngredientItems);
                }
                
                return list;
            }
        }

        public CollectionWithHeaderModel ToolsAndIngredientsCollection => new CollectionWithHeaderModel
        {
            Header = "Step " + Index,
            Items = ToolsAndIngredients
        };
    }
}

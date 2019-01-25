
namespace ClassRecipes.Core.Quantities
{
    public interface IPluralisable
    {
        string Singular { get; }

        string Plural { get; }
    }
}

using System.Security.Cryptography.X509Certificates;

public class Recipe
{
    public List<Ingredient> Ingredients { get; }

    public Recipe(List<Ingredient> ingredientList)
    {
        Ingredients = ingredientList;

    }
}

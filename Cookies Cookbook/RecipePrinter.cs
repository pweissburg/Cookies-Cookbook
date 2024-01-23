// user can create and save cookie recipes
//user can select infredients that will be included in the recipe from a list
//the recipe can then be saved to a text file alongside existing recipes. The text file might be either in a .txt or .json format, depending on the setting

public static class RecipePrinter
{
    public static void PrintSingleRecipe(Recipe recipe)
    {
        foreach (var ingredient in recipe.Ingredients)
        {
            Console.WriteLine($"{ingredient.Name}. {ingredient.Instructions}");
        }
    }

    public static void PrintAllRecipes(List<Recipe> recipeList)
    {
        if (recipeList.Count > 0)
        {
            int recipeNumber = 1;
            foreach (var recipe in recipeList)
            {
                Console.WriteLine($"***** {recipeNumber} *****");
                PrintSingleRecipe(recipe);
                Console.WriteLine();
                recipeNumber++;
            }
        }
    }

}




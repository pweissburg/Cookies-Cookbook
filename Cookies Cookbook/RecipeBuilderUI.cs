public static class RecipeBuilderUI
{
    public static void ExitApp()
    {
        Console.WriteLine("Press any key to exit");
        Console.ReadLine();
    }
    public static void GetExistingRecipes(string fileName)
    {
        if (File.Exists(fileName))
        {
            Console.WriteLine("Existing Recipes are:");
            Console.WriteLine(Environment.NewLine);
            var deserializedLists = FileHandler.LoadRecipeFromJsonFile(fileName);
            var listOfRecipes = new List<Recipe>();
            foreach (var ingredientList in deserializedLists)
            {
                // create a new recipe and add it to the list of recipes
                listOfRecipes.Add(new Recipe(ingredientList));
            }
            RecipePrinter.PrintAllRecipes(listOfRecipes);
        }
        else
        {
            Console.WriteLine("No recipes exist yet.");
            Console.WriteLine(Environment.NewLine);
        }
    }
    public static List<Ingredient> GetIngredientsForRecipe()
    {
        Console.WriteLine("Create a new cookie recipe! Available ingredients are:");
        ListAllIngredients.PrintAll();

        var recipeIngredients = new List<Ingredient>();
        bool isNumber = true;
        while (isNumber)
        {
            Console.WriteLine("Add an ingredient by its ID or type anything else if finished.");
            isNumber = int.TryParse(Console.ReadLine(), out var choice);
            if (isNumber && (choice > 0 && choice < 8))
            {
                recipeIngredients.Add(ListAllIngredients.GetIngredientById(choice));
            }

        }
        if (!AreThereEnoughIngredients(recipeIngredients))
        {
            Console.WriteLine("No ingredients have been selected. Recipe will not be saved.");
            
        }
        else Console.WriteLine($"Recipe added: ");
        RecipePrinter.PrintSingleRecipe(new Recipe(recipeIngredients));

        return recipeIngredients;

    }

    public static bool AreThereEnoughIngredients(List<Ingredient> ingredients)
    {
        if (ingredients.Count == 0)
        {
            return false;
        }
        else return true;
    }
}
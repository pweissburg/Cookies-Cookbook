public static class CookieRecipeApp
{
    public static void RunApp(string filePath)
    {
        RecipeBuilderUI.GetExistingRecipes(filePath);
        var existingRecipes = FileHandler.LoadRecipeFromJsonFile(filePath);
        var listOfIngredientsForRecipe = RecipeBuilderUI.GetIngredientsForRecipe();
        if (listOfIngredientsForRecipe.Count > 0)
        {
            existingRecipes.Add(listOfIngredientsForRecipe);
            FileHandler.SaveRecipeToJsonFile(existingRecipes);
        }
        
        RecipeBuilderUI.ExitApp();
    }

}
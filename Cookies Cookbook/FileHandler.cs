using System.Text.Json;

public static class FileHandler
{
    public const string fileType = "json";
    public static void SaveRecipeToJsonFile(List<List<Ingredient>> recipes)
    {
        string fileNameWithExtension = "recipes" + "." + fileType;
        var jsonString = JsonSerializer.Serialize(recipes);
        File.WriteAllText(fileNameWithExtension, jsonString);

    }

    public static List<List<Ingredient>> LoadRecipeFromJsonFile(string fileName)
    {
        if (File.Exists(fileName))
        {
            var fileContents = File.ReadAllText(fileName);
            var deserializedLists = JsonSerializer.Deserialize<List<List<Ingredient>>>(fileContents);
            return deserializedLists;
        }
        else
            return [];
    }
}
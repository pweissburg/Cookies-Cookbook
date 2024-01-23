

public static class ListAllIngredients
{
    public static List<Ingredient> PutAllIngredientsInAList()
    {
        var allIngredients = new List<Ingredient>
                                {
                                    new WheatFlour(),
                                    new CoconutFlour(),
                                    new Butter(),
                                    new Chocolate(),
                                    new Sugar(),
                                    new Cardamom(),
                                    new Cinnamon(),
                                    new CocoaPowder()
                                };
        return allIngredients;
    }
    public static void PrintAll()
    {
        var allIngredients = PutAllIngredientsInAList();

        foreach (var ingredient in allIngredients)
        {
            Console.WriteLine($"{ingredient.Id}. {ingredient.Name}");
        }
    }

    public static Ingredient GetIngredientById(int ingredientId)
    {
        var allIngredients = PutAllIngredientsInAList();
        foreach (var ingredient in allIngredients)
        {
            if (ingredient.Id == ingredientId)
            {
                return ingredient;
            }
        }
        return new Ingredient();

    }
}
public class WheatFlour : Ingredient
{
    public override int Id { get; } = 1;
    public override string Name { get; } = "Wheat flour";
    public override string Instructions { get; } = "Sieve. Add to other ingredients.";

}
public class CoconutFlour : Ingredient
{
    public override int Id { get; } = 2;
    public override string Name { get; } = "Coconut flour";
    public override string Instructions { get; } = "Sieve. Add to other ingredients.";

}
public class Butter : Ingredient
{
    public override int Id { get; } = 3;
    public override string Name { get; } = "Butter";
    public override string Instructions { get; } = "Melt on low heat. Add to other ingredients.";

}
public class Chocolate : Ingredient
{
    public override int Id { get; } = 4;
    public override string Name { get; } = "Chocolate";
    public override string Instructions { get; } = "Melt in a water bath. Add to other ingredients.";

}
public class Sugar : Ingredient
{
    public override int Id { get; } = 5;
    public override string Name { get; } = "Sugar";
    public override string Instructions { get; } = "Sieve. Add to other ingredients.";

}
public class Cardamom : Ingredient
{
    public override int Id { get; } = 6;
    public override string Name { get; } = "Cardamom";
    public override string Instructions { get; } = "Take half a teaspoon. Add to other ingredients.";

}
public class Cinnamon : Ingredient
{
    public override int Id { get; } = 7;
    public override string Name { get; } = "Cinnamon";
    public override string Instructions { get; } = "Take half a teaspoon. Add to other ingredients.";

}
public class CocoaPowder : Ingredient
{
    public override int Id { get; } = 8;
    public override string Name { get; } = "Cocoa powder";
    public override string Instructions { get; } = "Add to other ingredients.";

}
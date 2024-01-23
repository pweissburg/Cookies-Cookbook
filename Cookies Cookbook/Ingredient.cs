
using System.Text.Json.Serialization;

[JsonDerivedType(typeof(Ingredient), typeDiscriminator: "base")]
[JsonDerivedType(typeof(WheatFlour), typeDiscriminator: "WheatFlour")]
[JsonDerivedType(typeof(CoconutFlour), typeDiscriminator: "CoconutFlour")]
[JsonDerivedType(typeof(Butter), typeDiscriminator: "Butter")]
[JsonDerivedType(typeof(Chocolate), typeDiscriminator: "Chocolate")]
[JsonDerivedType(typeof(Sugar), typeDiscriminator: "Sugar")]
[JsonDerivedType(typeof(Cardamom), typeDiscriminator: "Cardamom")]
[JsonDerivedType(typeof(Cinnamon), typeDiscriminator: "Cinnamon")]
[JsonDerivedType(typeof(CocoaPowder), typeDiscriminator: "CocoaPowder")]

public class Ingredient
{
    public virtual int Id { get; }
    public virtual string Instructions { get; } = "Ingredient instructions";
    public virtual string Name { get; } = "Ingredient name";
    public void Describe() => Console.WriteLine($"This ingredient's name is {Name}. The preparation instructions are: {Instructions}");

}

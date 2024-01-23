////using Trying_Stuff_Outski.Extension_Methods;

//////properties (properties always start with capital letter whether private or public. names are nouns.. closer to a method than a field
//////backing field
//////accessors
//////differences between fields and properties
//////when we should use fields vs properties


//////can also just remove the setter... we can declare the value of the property using this method or in the constructor
////// now the Width field is a property and not a field. we don't need the field
////// fields have no separate getter and setter and have a single access modifier
////// properties have separate and optional getter and/or setters and each getter/setter has it's own access modifier. you can remove a getter or setter.

//////fields should always be private
//////properties can safely be public
//////fields cannot be overridden in derived classes
//////properties can be overridden in derived classes

//////DateTime today = DateTime.Today;
//////Console.WriteLine($"Today is {today}");
//////Console.WriteLine($"The year is  is {today.Year}");

//////Console.ReadKey();
////// the below is an object initializer. If I use a non-empty constructor, the properties I set in the initializer will overwrite the constructor inputs if they conflict.
////// instead of set, use init and you'll be able to set a value when you initialize the instance but not change it once it's initialized
////// use the initializer because it's more readable since you're listing the properties' names when you initialize


//////var person = new Person
//////{
//////    Name = "John",
//////    YearOfBirth = 1981
//////};

//////Console.WriteLine($"Person's name is {person.Name}");
//////Console.WriteLine($"Person's year of birth is {person.YearOfBirth}");
//////person.WriteDescription();
//////Console.WriteLine(DateTime.Today.Day);

//////class Person
//////{
//////    int thisYear = DateTime.Now.Year;
//////    public string Name { get; set; }
//////    public int YearOfBirth { get; set;}

//////    public string Description => $"Name is {Name} and the age is {thisYear - YearOfBirth}.";

//////    public void WriteDescription()
//////    {
//////        Console.WriteLine(Description);
//////    }

//////public Person(string name,int yearOfBirth)
//////{
//////    Name = name;
//////    YearOfBirth = yearOfBirth;
//////}
//////}
////// if the calculation is performance-heavy, use a method rather than a property.

////// static classes
////// for a calculator class for example - it is stateless (one instance is the same as the next).
////// static methods belong to a class as a whole, not to a specific instance.
////// static methods can't use the instance data (values of fields or returned by properties) - can't refer to width or height, etc.
////// static methods and limitations
////// static classes can only contain static methods
////// non-static classes CAN contain static methods
////// a static class cannot be instantiated (cannot create an instance). It is only a container for methods (makes sense).
////// why all const fields are implicitly static => const fields are stored in the class rather than in the instance, which saves memory.
////// we call static methods by calling the class name rather than the instance name.
//////ex. Console.WriteLine() - Console is the static class. vs fido.Describe() [not static] vs Dog.Describe() [static]
////// if a private method doesn't use instance data, make it static. This clearly shows that this method does not change the state of the object.

//////static class NumberToDayOfWeekTranslator
//////{
//////    public static string Translate(int number)
//////    {
//////        switch (number)
//////        {
//////            case 1: return "Monday";
//////            case 2: return "Tuesday";
//////            case 3: return "Wednesday";
//////            case 4: return "Thursday";
//////            case 5: return "Friday";
//////            case 6: return "Saturday";
//////            case 7: return "Sunday";
//////            default: return "Invalid day of the week";
//////        }
//////    }
//////}

////// static fields and properties
////// static fields and properties belong to the class, not any instance
////using System.Diagnostics;
////using System.Diagnostics.CodeAnalysis;

////Console.WriteLine(
////StringsTransformator.TransformSeparators("input,is,good", ",", "+")
////);

//////single responsibility principle
////// classes should have 1 function and have only 1 reason to change
////// repositories are classes or components that encapsulate the logic required to access data sources

//////88.
//////recommended order of methods in a class
//////risk of making methods public, even if only for getting
//////contents can be modified, eg names.All = new List<string>(); names.All.Clear();
//////put public methods above private ones
////// readonly collections - not getting there yet.

//////89. 
//////DRY principal - Don't Repeat Yourself
////// shouldn't have multiple places in the code where the same business decisions are defined
//////when code duplication is not a bad thing

//////90.
////// adding new files to a project
////// each class should be in separate file
////// 2 ways: manually and right clicking on the class name -> refactoring -> yada yada
////// how to move classes to their own files
////// what namespaces are
////// namespaces declare a scope that contains a set of related types
////// if not declared specifically, the code belongs to the global namespace
////// using directives
////// to import namespaces, use 'using'
////// you can actually right click the method that's referring to the namespace and vs will suggest 'using NameSpace'
////// what file-scoped namespace declarations are
////// namespaces should reflect the folder structure

//////91.
////// Global using directives
////// using System.Diagnostics; -> this has the Stopwatch method. 
////// global using System.Diagnostics; -> this means that this directive applies to all files in the project
////// how to measure the time of code execution

////////var stopwatch = new System.Diagnostics.Stopwatch();
//////var stopwatch = Stopwatch.StartNew();
//////stopwatch.Start();
//////for (int i = 0; i < 10000; i+=10)
//////{
//////    Console.WriteLine($"This is line {i + 1}");
//////}
//////stopwatch.Stop();
//////Console.WriteLine($"Total time is {stopwatch.Elapsed}");

//////
////// can also assign numbers to each value

//////enum httpCodes
//////{
//////    Ok = 200,
//////    NotFound = 404,
//////    InternalServerError = 500
//////}
//////bool boob = true;
//////string message = boob
//////    ? "you win"
//////    : "you suck";
//////Console.WriteLine(message);

//////var iteration = 1;
//////var items = new List<string> { "testicles", "whatever", "grizzly" };
//////var results = new List<string>();
//////foreach (var item in items)
//////{
//////    Console.WriteLine($"Iteration: {iteration}");
//////    Console.WriteLine($"Before: {item}");
//////    results.Add(item.Substring(0, item.Length / 2));
//////    Console.WriteLine($"After: {item}");
//////    iteration++;
//////}
//////foreach (var result in results)
//////{
//////    Console.WriteLine(result);
//////}
//////decimal c = 10.99999999999999m;
////////int d = (int)c;
//////Console.WriteLine($"Decimal: {c}");
//////Console.WriteLine($"Int: {c}");

//////Console.WriteLine($"Is d a boolean? {c is bool}");
//////Console.WriteLine($"Is d an integer? {c is int}");
//////Console.WriteLine($"Is d a decimal? {c is decimal}");

//////int seasonNumber = (int)c;
//////var getSeasonName = (Season)seasonNumber;

//////Console.WriteLine(getSeasonName);

//////if (c is decimal numbie)
//////{
//////    Console.WriteLine(numbie);
//////}

//////public enum Season
//////{
//////    Spring = 10,
//////    Summer,
//////    Autumn,
//////    Winter

////var newList = new List<int>() {1,5,10,8,12,4,5};
////var tList = newList.TakeEverySecond();
//////foreach(var t in newList)
//////{
//////    Console.WriteLine($"Index: {index}, Value: {t}");
//////    index++;
//////}
////Console.WriteLine(tList.Count);
////foreach (int i in tList)
////{
////    Console.WriteLine($"Value is: {i}");
////}

//////var multiLine =
//////@"aaa
//////bbb
//////ccc
//////ddd";

//////Console.WriteLine($@"String
//////literals
//////multiline
//////string has {multiLine.CountLines()}
//////{ StringExtension.CountLines(multiLine)} lines");

var shapes = new List<Shape>();
shapes.Add(new Square(4.15));
shapes.Add(new Rectangle(10.5, 11.7));
shapes.Add(new Circle(10.1));

foreach (var shape in shapes)
{
Console.WriteLine($"Shape is a {shape.Name} with area {shape.CalculateArea()}");
}
public static class ExerciseShapes
{
    public static List<double> GetShapesAreas(List<Shape> shapes)
    {
        var result = new List<double>();

        foreach (var shape in shapes)
        {
            result.Add(shape.CalculateArea());
        }

        return result;
    }
}

public abstract class Shape
{
    public abstract double CalculateArea();
    public abstract string Name { get; }
}

public class Square : Shape
{
    public double Side { get; }
    public override string Name => "Square";

    public Square(double side)
    {
        Side = side;
    }

    public override double CalculateArea() => Side * Side;
}


public class Rectangle : Shape
{
    public double Width { get; }
    public double Height { get; }
    public override string Name => "Rectangle";

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double CalculateArea() => Width * Height;
}

public class Circle : Shape
{
    public double Radius { get; }
    public override string Name => "Circle";

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea() => Math.PI * Radius * Radius;
}

//var exercise = Exercise.Transform(4);
//    Console.WriteLine(exercise);
//public static class Exercise
//{
//    public static int Transform(int number)
//    {
//        var transformations = new List<INumericTransformation>
//            {
//                new By1Incrementer(),
//                new By2Multiplier(),
//                new ToPowerOf2Raiser()
//            };

//        var result = number;
//        foreach (var transformation in transformations)
//        {
//            Console.WriteLine($"Before Result is: {result}");
//            result = transformation.Transform(result);
//            Console.WriteLine($"After Result is: {result}");

//        }
//        return result;
//    }
//}

//public interface INumericTransformation
//{
//    public int Transform(int a) => a;
//}

//public class By1Incrementer : INumericTransformation
//{
//    public int Transform(int a) => a+1;

//}

//public class By2Multiplier : INumericTransformation
//{
//    public int Transform(int a) => a * 2;
//}

//public class ToPowerOf2Raiser : INumericTransformation
//{
//    public int Transform(int a) => a * a;
//}

//using System.Text.Json;
//var eddie = new Person
//{
//    Name = "Eddie",
//    Age = 50
//};

//var asJson = JsonSerializer.Serialize(eddie);
//Console.WriteLine(asJson);

//public class Person
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//}

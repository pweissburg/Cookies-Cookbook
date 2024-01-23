// See https://aka.ms/new-console-template for more information

//properties (properties always start with capital letter whether private or public. names are nouns.. closer to a method than a field
//backing field
//accessors
//differences between fields and properties
//when we should use fields vs properties


//can also just remove the setter... we can declare the value of the property using this method or in the constructor
// now the Width field is a property and not a field. we don't need the field
// fields have no separate getter and setter and have a single access modifier
// properties have separate and optional getter and/or setters and each getter/setter has it's own access modifier. you can remove a getter or setter.

//fields should always be private
//properties can safely be public
//fields cannot be overridden in derived classes
//properties can be overridden in derived classes

//DateTime today = DateTime.Today;
//Console.WriteLine($"Today is {today}");
//Console.WriteLine($"The year is  is {today.Year}");

//Console.ReadKey();
// the below is an object initializer. If I use a non-empty constructor, the properties I set in the initializer will overwrite the constructor inputs if they conflict.
// instead of set, use init and you'll be able to set a value when you initialize the instance but not change it once it's initialized
// use the initializer because it's more readable since you're listing the properties' names when you initialize


//var person = new Person
//{
//    Name = "John",
//    YearOfBirth = 1981
//};

//Console.WriteLine($"Person's name is {person.Name}");
//Console.WriteLine($"Person's year of birth is {person.YearOfBirth}");
//person.WriteDescription();
//Console.WriteLine(DateTime.Today.Day);

//class Person
//{
//    int thisYear = DateTime.Now.Year;
//    public string Name { get; set; }
//    public int YearOfBirth { get; set;}

//    public string Description => $"Name is {Name} and the age is {thisYear - YearOfBirth}.";

//    public void WriteDescription()
//    {
//        Console.WriteLine(Description);
//    }

//public Person(string name,int yearOfBirth)
//{
//    Name = name;
//    YearOfBirth = yearOfBirth;
//}
//}
// if the calculation is performance-heavy, use a method rather than a property.

// static classes
// for a calculator class for example - it is stateless (one instance is the same as the next).
// static methods belong to a class as a whole, not to a specific instance.
// static methods can't use the instance data (values of fields or returned by properties) - can't refer to width or height, etc.
// static methods and limitations
// static classes can only contain static methods
// non-static classes CAN contain static methods
// a static class cannot be instantiated (cannot create an instance). It is only a container for methods (makes sense).
// why all const fields are implicitly static => const fields are stored in the class rather than in the instance, which saves memory.
// we call static methods by calling the class name rather than the instance name.
//ex. Console.WriteLine() - Console is the static class. vs fido.Describe() [not static] vs Dog.Describe() [static]
// if a private method doesn't use instance data, make it static. This clearly shows that this method does not change the state of the object.

//static class NumberToDayOfWeekTranslator
//{
//    public static string Translate(int number)
//    {
//        switch (number)
//        {
//            case 1: return "Monday";
//            case 2: return "Tuesday";
//            case 3: return "Wednesday";
//            case 4: return "Thursday";
//            case 5: return "Friday";
//            case 6: return "Saturday";
//            case 7: return "Sunday";
//            default: return "Invalid day of the week";
//        }
//    }
//}

// static fields and properties
// static fields and properties belong to the class, not any instance
public static class StringsTransformator
{
    public static string TransformSeparators(
        string input,
        string originalSeparator,
        string targetSeparator)
    {
    //take input string
    //separate by separator
        string[] intermediary = input.Split(originalSeparator);
    // re-join by string.join
        string result = string.Join(targetSeparator, intermediary);
    //return string
        return result;
    }
}

//single responsibility principle
    // classes should have 1 function and have only 1 reson to change
    // repositories are classes or components that encapsulate the logic required to access data sources

//88.
    //recommended order of methods in a class
    //risk of making methods public, even if only for getting
        //contents can be modified, eg names.All = new List<string>(); names.All.Clear();
    //put public methods above private ones
    // readonly collections - not getting there yet.

//89. 
    //DRY principal - Don't Repeat Yourself
        // shouldn't have multiple places in the code where the same business decisions are defined
    //when code duplication is not a bad thing

//90.
    // adding new files to a project
        // each class should be in separate file
        // 2 ways: manually and 
    // how to move classes to their own files
    // what namespaces are
    // using directives
    // what file-scoped namespace declarations are

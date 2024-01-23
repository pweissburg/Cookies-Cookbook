

namespace Trying_Stuff_Outski.Extension_Methods
{
    public static class StringExtension
    {
        public static int CountLines(this string input) => //this must be first parameter
            input.Split(Environment.NewLine).Length;
    }
}

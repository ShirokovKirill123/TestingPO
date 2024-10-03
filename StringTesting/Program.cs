using Testing;
using static Testing.StrOperations;

namespace StringTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StrOperations stringFunctions = new StrOperations();

            string str1 = "Hello";
            string str2 = "World";

            string concatenated = stringFunctions.Concatenate(str1, str2);
            string upper = stringFunctions.ToUpperCase(str1);
            string lower = stringFunctions.ToLowerCase(str2);
            bool contains = stringFunctions.ContainsSubstring(str1, "He");
            string replaced = stringFunctions.ReplaceSubstring(str1, "He", "hi");

            Console.WriteLine($"Concat: {concatenated}");
            Console.WriteLine($"Upper case of '{str1}': {upper}");
            Console.WriteLine($"Lower case of '{str2}': {lower}");
            Console.WriteLine($"Does '{str1}' contain 'He'? {contains}");
            Console.WriteLine($"Replace 'He' in '{str1}' with 'hi': {replaced}");
        }
    }
}

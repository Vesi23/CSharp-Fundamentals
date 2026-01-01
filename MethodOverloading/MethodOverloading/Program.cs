using System;

namespace MethodOverloading
{
    internal class Program
    {

        // method overload 1
        static void IntroduceFriends(string frinedOne, string friendTwo)
        {
            Console.WriteLine($"Meet my friends {frinedOne} and {friendTwo}.");
        }

        // method overload 2
        static void IntroduceFriends(string frinedOne, string friendTwo, string friendThree)
        {
            Console.WriteLine($"Meet my friends {frinedOne}, {friendTwo} and {friendThree}.");
        }

        // method overload 3
        static void IntroduceFriends()
        {
            Console.WriteLine("There is no one who needs to be introduced.");
        }

        // Main method - entry point of the program
        static void Main(string[] args)
        {
            IntroduceFriends("Laika", "Albert");
            IntroduceFriends("Naomi", "Jasmine", "Cyrus");
            IntroduceFriends();
        }
    }
}

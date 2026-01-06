using System;

namespace GetOnlyProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Forest f = new Forest();
            f.Name = "Congo";
            f.Trees = 0;
            f.Biome = "Tropical";
            f.Age = 10000; // This line will cause a compile-time error

            Console.WriteLine(f.Age); //Тази грешка означава, че private setter ни е попречил да зададем стойност Ageизвън класа (което е добре!).

        }
    }
}

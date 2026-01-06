using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Forest f = new Forest();
            //f.name = "Congo";//deleted because name is private
            f.Name = "Congo";//using property to set private field
            f.trees = 0;
            f.age = 0;
            f.Biome = "Desert";

            Console.WriteLine(f.Name);

            // Prints Unknown
            Console.WriteLine(f.Biome);

        }
    }
}

using System;
using System.Security.Cryptography.X509Certificates;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                        Forest f = new Forest();
                        f.name = "Congo";
                        f.trees = 0;
                        f.biome = "Tropical";

                        Console.WriteLine(f.name);
                        Console.WriteLine(f.biome);
            -> You should see an error: This error occurs because you are using the parameterless constructor Forest() in Program.cs. 
            This no longer works because a constructor Forest(string, string) has been defined.
                  */

            Forest f = new Forest("Congo", "Tropical");
            f.trees = 0;

            Console.WriteLine(f.name);
            Console.WriteLine(f.biome);
        }
    }
}

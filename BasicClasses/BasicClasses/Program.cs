using Microsoft.SqlServer.Server;
using System;

namespace BasicClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Forest f = new Forest();
            f.name = "Matteo";
            f.trees = 20;
            f.age = 23;
            f.biome = "Savanna";
            Console.WriteLine(f.name);
        }
    }
}

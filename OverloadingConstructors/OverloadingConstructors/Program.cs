using Microsoft.SqlServer.Server;
using System;

namespace OverloadingConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Forest f = new Forest("Congo", "Tropical");
            f.trees = 0;

            Forest f2= new Forest("Rendlesham");
            Console.WriteLine(f2.biome);
                
        }
    }
}

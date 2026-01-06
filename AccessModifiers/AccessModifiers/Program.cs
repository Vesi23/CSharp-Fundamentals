using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Forest f = new Forest("Congo", "Tropical");

            f.Grow();
            //f.trees += 20;
            //f.age++; // Cannot access private fields

            f.AnnounceForest();
        }
    }
}

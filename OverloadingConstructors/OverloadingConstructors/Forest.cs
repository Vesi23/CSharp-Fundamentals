using System;

namespace OverloadingConstructors
{
    class Forest
    {
        public string name;
        public int trees;
        public int age;
        public string biome;

        public Forest(string name, string biome)
        {
            this.name = name;
            this.biome = biome;
            age = 1;
        }

        // огато н€кой подаде само name, извикай други€ конструктор и му подай "Unknown" като biome.
        // “ова е пример за constructor overloading
        public Forest(string name):this(name, "Unknown")
        {
            Console.WriteLine("Biome not specified, set to 'Unknown'");
        }

        public int Grow()
        {
            this.trees += 30;
            this.age++;
            return this.trees;
        }

        public int Burn()
        {
            trees -= 20;
            age++;
            return trees;
        }
    }

}
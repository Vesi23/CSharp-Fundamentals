using System;

namespace AccessModifiers
{

    class Forest
    {
        public string name;
        // private fields
        private int trees;
        private int age;
        public string biome;

        public Forest(string name, string biome)
        {
            this.name = name;
            this.biome = biome;
            age = 1;
        }

        // public method to modify private fields 
        public void Grow()
        {
        this.trees += 20;
        this.age++;
        }

        public void AnnounceForest()
        {
            Console.WriteLine($"The {name} {biome} Forest is {age} years old and has {trees} trees");
        }

    }

}
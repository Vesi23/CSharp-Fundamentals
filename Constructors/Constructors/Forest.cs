using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Forest
    {
        public string name;
        public int trees;
        public int age;
        public string biome;

        // Constructor-> same name as class
        public Forest(string name, string biome)
        {
            // Initialize fields
            //need to use this keyword to distinguish between field and parameter
            this.name = name;
            this.biome = biome;
            this.age = 1;
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

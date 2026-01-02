using System;

namespace ThisKeyword
{
    class Forest
    {
        public string name;
        public int trees;
        public int age;
        public string biome;

        public int Grow()
        {
            //adding this here does not change how the code works.
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


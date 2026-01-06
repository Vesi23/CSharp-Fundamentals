using System;

namespace Properties
{
    public class Forest
    {
        //fields
        private string name;//private field
        public int trees;
        public int age;
        private string biome;//private field

        //properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Biome
        {
            get { return biome; }
            set
            {
                if (value == "Tropical" || value == "Temperate" || value == "Boreal")
                {
                    biome = value;
                }
                else
                {
                    biome = "Unknown";
                }
            }
        }
    }
}
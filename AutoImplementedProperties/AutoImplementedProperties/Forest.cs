using System;

namespace AutoImplementedProperties
{
  class Forest
  {
    //private string name;
        /*
    public string Name
    {
      get {
        return name;
      }
      set {
        name = value;
      }
    }
        */ 
    public string Name { get; set; } // Auto-implemented property

        /*
        private int trees;
        public int Trees
        {
            get
            {
                return trees;
            }
            set
            {
                trees = value;
            }
        }*/
        public int Trees { get; set; } // Auto-implemented property

        public int age;

    private string biome;
    public string Biome 
    {
      get {
        return biome;
      }
      set {
        string[] validBiomes = {"Tropical", "Temperate", "Boreal"};
        if (Array.IndexOf(validBiomes, value) >= 0) {
          biome = value;
        }
        else {
          biome = "Unknown";
        }
      }
    }
  }

}
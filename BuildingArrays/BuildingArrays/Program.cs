using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare the array.
            string[] summerStrut;

            //initialize the array.
            summerStrut = new string[]
            {
             "Juice",
             "Missing U",
             "Raspberry Beret",
             "New York Groove",
             "Make Me Feel",
             "Rebel Rebel",
             "Despacito",
             "Los Angeles"
            };

            int[] ratings = { 3, 2, 4, 4, 5, 4, 5, 3 };
            int lenght = ratings.Length;
            Console.WriteLine(lenght);



        }
    }
}

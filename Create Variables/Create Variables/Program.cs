using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Shadow";
            string breed = "Golden Retriever";

            int age = 5;
            double weight = 65.22;
            bool spayed = true;

            System.Console.WriteLine($"Name: {name}");
            System.Console.WriteLine($"Breed: {breed}");
            System.Console.WriteLine($"Age: {age}");
            System.Console.WriteLine($"Weight: {weight}");
            System.Console.WriteLine($"Spayed: {spayed}");
          

        }
    }
}

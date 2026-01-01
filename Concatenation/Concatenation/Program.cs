using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concatenation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare the variables
            string beginning="When everything start. ";
            string middle="The story was interesting. ";
            string end="Soo, this is the end of the story.";

            // Concatenate the string and the variables
            string story=beginning + middle + end;

            // Print the story to the console 
            Console.WriteLine(story);

        }
    }
}

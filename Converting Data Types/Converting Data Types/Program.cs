using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converting_Data_Types
{
    internal class Program
    {
        /* Let’s write a program that asks a learner for their favorite number and
        see if we can implicitly convert their response to an int.
        */
        static void Main(string[] args)
        {
            //Console.ReadLine() will always return a string.

            // Ask user for fave number

            Console.Write("Enter your favorite number!: ");
            int faveNumber=Convert.ToInt32(Console.ReadLine());

            // Turn that answer into an int



        }
    }
}

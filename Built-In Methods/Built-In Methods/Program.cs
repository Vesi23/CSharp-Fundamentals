using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Built_In_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Starting variables 
            int numberOne = 12932;
            int numberTwo = -2828472;

            // Use built-in methods and save to variable 
            double numberOneSqrt=Math.Floor(Math.Sqrt(Math.Abs(numberOne)));

            // Use built-in methods and save to variable 
            double numberTwoSqrt = Math.Floor(Math.Sqrt(Math.Abs(numberTwo)));

            // Print the lowest number
            Console.WriteLine(Math.Min(numberOneSqrt, numberTwoSqrt)); //за да не изведе NaN добавям Math.Abs()
        }
    }
}

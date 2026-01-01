using System;

namespace PlanetCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Your Age
            int userAge = 23;

            // Length of years on Jupiter (in Earth years)
            double jupiterYears= 11.86;

            // Age on Jupiter 
            double jupiterAge = userAge /jupiterYears;

            // Time to Jupiter
            double journeyToJupiter = 6.142466;

            // New Age on Earth
            double newEarthAge= userAge + journeyToJupiter;

            // New Age on Jupiter
            double newJupiterAge= newEarthAge / jupiterYears;

            // Log calculations to console
            Console.WriteLine("Your age on Earth is: " + userAge);
            Console.WriteLine("Your age on Jupiter is: " + jupiterAge);
            Console.WriteLine("Your new age on Earth after the journey is: " + newEarthAge);
            Console.WriteLine("Your new age on Jupiter after the journey is: " + newJupiterAge);
       


        }
    }
}

using System;

namespace Return
{
    class Program
    {

        //При създаване на метод използвам string като тип на връщане
        static string DecoratePlanet(string message)
        {

            return $"***  Welcome to {message} ***";
        }
        static void Main(string[] args)
        {
            //DecoratePlanet("Mars");
            string output = DecoratePlanet("Jupiter");
            Console.WriteLine(output); 

        }

    }
}

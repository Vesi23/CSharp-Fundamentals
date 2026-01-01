using System;

namespace OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            VisitPlanets(3);
            VisitPlanets(4);
            VisitPlanets(5);
            VisitPlanets();//Тук извиквам optional param или поставям default стойност в създаването на метода с = пр: int numberOfPlanets=0
            //Извикам празно за да се изпринтира тази стойност
        }

        static void VisitPlanets(int numberOfPlanets=0)
        {
            Console.WriteLine($"You visited {numberOfPlanets} new planets...");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparisonOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Създайте doubleпроменлива с име timeToDinnerи запазете разликата в часове между 14:00 и 18:00 часа.
            double timeToDinner = 4;
            double distance = 95;
            double rate = 30;

            double tripDuration= distance / rate;

            bool answer = (tripDuration <= timeToDinner);
            Console.WriteLine(answer);


        }
    }
}

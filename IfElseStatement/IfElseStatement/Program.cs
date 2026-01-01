using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = 10;
            string weather = "nice";

            if(people <=10 && weather == "nice") {
                Console.WriteLine("SaladMart");
            }
            else
            {
                Console.WriteLine("Soup N Sandwich");
            }
        }
    }
}

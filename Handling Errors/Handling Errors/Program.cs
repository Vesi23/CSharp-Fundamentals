using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handling_Errors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int number = 38498.3222; тук е грешка, защото се опитваме да присвоим дробно число на цяло число
            double number = 38498.3222;

            //dinosaur = "Barney"; тук е грешно защото променливата не е декларирана
            string dinosaur = "Barney";

            //double lock = 293.000; тук е грешно защото "lock" е запазена дума в C#
            double lockNum = 293.000;

            //bool is.yes = true; тук е грешно защото не може да има точка в името на променлива
            bool is_yes = true;

            //string band = "The Low Anthem" тук няма точка и запетая в края на изречението
            string band = "The Low Anthem";

            Console.WriteLine(number);
            Console.WriteLine(dinosaur);
            Console.WriteLine(lockNum);
            Console.WriteLine(band);
            Console.WriteLine(is_yes);

        }
    }
}

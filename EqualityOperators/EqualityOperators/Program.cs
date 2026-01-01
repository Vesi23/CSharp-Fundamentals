using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualityOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cookiesSoldGuess = 250;

            int storeOneCookies = 110;
            int storeTwoCookies = 135;
            int cookiesSoldActual= storeOneCookies + storeTwoCookies;

            //дали сте познали правилно общия брой продадени бисквитки
            bool guessedCorrect= (cookiesSoldGuess == cookiesSoldActual);

            Console.WriteLine(guessedCorrect); //False
        }
    }
}

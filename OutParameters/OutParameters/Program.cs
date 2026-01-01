using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutParameters
{
    internal class Program
    {


        static void Main(string[] args)
        {
            string scoreAsString = "85.6";
            string statement = "Hello World";
            bool outcome; 
            double scoreAsDouble;

            //тук outcome проверява дали преобразуването е успешно
            //а scoreAsDouble съдържа преобразуваната стойност
            //out parameters се използват за връщане на повече от една стойност от метод
            //TryParse използва out parameter за връщане на преобразуваната стойност
            //TryParse връща булева стойност, която показва дали преобразуването е успешно
            outcome = Double.TryParse(scoreAsString, out scoreAsDouble);

            Console.WriteLine(outcome); //true
            Console.WriteLine(scoreAsDouble); //85.6

            string whispered=Whisper(statement,out bool marker);
            Console.WriteLine(marker); //false

        }

//        Сега, нека създадем наш собствен метод, който използва outпараметър!
//Декларирайте метод Whisper()с stringпараметър и out boolпараметър.Той трябва да върне string.
static string Whisper(string phrase, out bool wasWhisperCalled)
        {
            wasWhisperCalled= true;
            return phrase.ToLower();
        }

    }
}

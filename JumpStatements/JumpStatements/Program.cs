using System;

namespace JumpStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool buttonClick = false;
            int counter = 0;
            do
            {
                counter++;
                Console.WriteLine("BLARRRRR");
                if (counter == 3)
                {
                    //buttonClick = true;
                    break;
                }

            } while (!buttonClick);

           
        }
    }
}

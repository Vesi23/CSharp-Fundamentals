using System;

namespace ComparingLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] websites = { "twitter", "facebook", "gmail" };
            //int counter = 0;

            //while (counter < websites.Length)
            //{
            //    Console.WriteLine(websites[counter]);
            //    counter++;
            //}

            foreach (string site in websites)
            {
                Console.WriteLine(site);
            }
        }
    }
}

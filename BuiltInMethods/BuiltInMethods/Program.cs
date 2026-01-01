using System;

namespace BuiltInMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] summerStrut;

            summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };

            int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };

            int index = Array.IndexOf(ratings, 3);
            //Console.WriteLine(index);
            Console.WriteLine($"Song number {index+1} is rated three stars");

            Array.Reverse(summerStrut);
            string firstSong = summerStrut[0];
            string lastSong = summerStrut[summerStrut.Length - 1];
Console.WriteLine($"The first song is {firstSong} and the last song is {lastSong}");

            Array.Sort(summerStrut);
            Console.WriteLine(summerStrut[0]);
            Console.WriteLine(summerStrut[summerStrut.Length - 1]);



        }
    }
}

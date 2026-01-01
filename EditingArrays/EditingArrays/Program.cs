using System;

namespace EditingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] summerStrut;

            summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };

            //Swap the last song in the playlist out for another song of your choosing.
            summerStrut[7] = "Ballroom";

            int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };
            //Change the rating to reflect the playlist update. 
            ratings[7]= 5;

            Console.WriteLine($"Updated Playlist:{summerStrut[7]} {ratings[7]}");


        }
    }
}

using System;

namespace ClassTeams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Number of students
            int students = 18;

            // Number of students in a group
            int groupSize = 3;

            // Does groupSize go evenly into students?
         
            System.Console.WriteLine(students % groupSize); //ako e 0 to e ravno
        }
    }
}

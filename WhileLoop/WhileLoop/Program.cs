using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int emails = 20;
            while (emails >0)
            {
                emails--;
                Console.WriteLine($"You remove emails, new emails counter:{emails}");
               
            }
           
                Console.WriteLine("INBOX ZERO ACHIEVED!");
            
        }
    }
}

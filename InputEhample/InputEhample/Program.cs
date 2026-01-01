using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputEhample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            //Тук се очаква въвеждане от конзолата
            string input = Console.ReadLine();
            //принтване на въведеното от конзолата
            // интерполация на стринг е $"", а не както в JS с `${}`
            Console.WriteLine($"You are {input} years old");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElseIfStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ph = 3.0;

            if (ph < 7)
            {
                Console.WriteLine("Acidic");
            }else if (ph > 7)
            {
                Console.WriteLine("Basic");
            }
            else
            {
                Console.WriteLine("Neutral");
            }
        }
    }
}

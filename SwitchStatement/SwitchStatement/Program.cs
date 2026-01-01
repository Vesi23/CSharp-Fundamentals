using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ph = 4.5;


            switch (ph)
            {
                case <= 3:
                    Console.WriteLine("Very Acidic");
                    break;
                case < 7:
                    Console.WriteLine("Acidic");
                    break;
                case >= 11:
                    Console.WriteLine("Very Basic");
                    break;
                case > 7:
                    Console.WriteLine("Basic");
                    break;
                default:
                    Console.WriteLine("Neutral");
                    break;
            }
        }
    }
}

using System;

namespace Review
{
    class Program
    {
        static void Main(string[] args)
        {
            Forest f1 = new Forest("Amazon");
            f1.trees = 10;
            f1.Grow();
            Console.WriteLine(f1.trees);

        }
    }
}

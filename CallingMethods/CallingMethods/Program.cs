using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string designer = "Anders Hejlsberg";
 //Сега нека изпишем само второто име на Андерс.
//Първо, намерете индекса на интервала( " ") в низа designerи го запазете в променлива indexOfSpace.
            int indexOfSpace= designer.IndexOf(" ");

           //Създайте ново цяло число indexOfSecondNameи го инстанцирайте със стойност indexOfSpaceplus 1.
            int indexOfSecondName=indexOfSpace + 1;

            string secondName = designer.Substring(indexOfSecondName);
            Console.WriteLine(secondName);






            Console.WriteLine(designer);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{   enum Choice { Addition=1 , Subtraction, Product, Division};
    enum Volume { High, Low,Medium};
    enum Days { Monday, Tuesday, Wednesday};
    internal class EnumDemo
    {
        static void Main()
        {
            int n1 = 10, n2 = 9;
            int ch;
            Console.WriteLine("Enter ch");
            ch = byte.Parse(Console.ReadLine());
            switch(ch)
            {
                //case 1: Console.WriteLine(n1+n2); break; 
                //case 2: Console.WriteLine(n1 - n2); break;
                //case 3: Console.WriteLine(n1 * n2); break;
                //case 4: Console.WriteLine(n1 / n2); break;

                case (int)Choice.Addition: Console.WriteLine(n1 + n2); break;
                case (int)Choice.Subtraction: Console.WriteLine(n1 - n2); break;
                case (int)Choice.Product: Console.WriteLine(n1 * n2); break;
                case (int)Choice.Division: Console.WriteLine(n1 / n2); break;

            }
        }
    }
}

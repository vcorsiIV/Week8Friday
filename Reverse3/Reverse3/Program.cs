using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Reverse3
{
    class Program
    {
        private static void Reverse(ref int a, ref int b, ref int c)
        {
            int storedValC = c;
            c = a;
            a = storedValC;
            WriteLine("The integers have been reversed.");

        }


        static void Main(string[] args)
        {
            int firstInt, middleInt, lastInt;
            while(true)
                try
                {
                    WriteLine("Enter in the first Integer:");
                    firstInt = Convert.ToInt32(ReadLine());
                    break;
                }
                catch
                {
                    WriteLine("Not a valid input. Enter an INTEGER again.");
                }
            while (true)
                try
                {
                    WriteLine("Enter in the middle Integer:");
                    middleInt = Convert.ToInt32(ReadLine());
                    break;
                }
                catch
                {
                    WriteLine("Not a valid input. Enter an INTEGER again.");
                }
            while (true)
                try
                {
                    WriteLine("Enter in the last Integer:");
                    lastInt = Convert.ToInt32(ReadLine());
                    break;
                }
                catch
                {
                    WriteLine("Not a valid input. Enter an INTEGER again.");
                }

            WriteLine("You have entered in {0} , {1} , {2}", firstInt, middleInt, lastInt);
            Reverse(ref firstInt, ref middleInt, ref lastInt);
            WriteLine("The new order is:\n{0} , {1} , {2}", firstInt, middleInt, lastInt);


        }
    }
}

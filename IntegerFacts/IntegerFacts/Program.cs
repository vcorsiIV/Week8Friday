using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
//Felt like this is to simple of a program to make it a GUI

namespace IntegerFacts
{
    class Program
    {
        //First method is to create a Array of 20 integers or less if
        //-9999 is entered.
        private static int[] GenerateArr()
        {
            int insert;
            int counter = 0;
            int[] intArr = new int[20];
            while (counter < 20)
                //a try catch to accept only integers in this while loop
                try
                {
                    WriteLine("Enter in a Integer:");
                    insert = Convert.ToInt32(ReadLine());
                    //end the loop if user enters -9999
                    if (insert != -9999)
                    {
                        intArr[counter] = insert;
                        ++counter;
                    }
                    else
                        break;

                }
                catch
                {
                    WriteLine("Not a valid input. Enter an INTEGER again.");
                }
            //set up a new array so that empty slots are not passed through
            //making the results have false data.
            int[] retArr = new int[counter];

            for (int i = 0; i < counter; ++i)
            {
                retArr[i] = intArr[i];
            }
            return retArr;
        }
        
        //this method using the out parameters to set values to the Main Method.
        private static void IntegerFacts(out int [] getArr, out int highest, out int lowest, out int sum, out double average)
        {
            sum = 0;
            getArr = GenerateArr();

            for(int i = 0; i<getArr.Length; ++i)
            {
                sum += getArr[i];
            }
            highest = getArr.Max();
            lowest = getArr.Min();
            average = (Convert.ToDouble(sum) / Convert.ToDouble(getArr.Length))/1.00;


        }

        static void Main(string[] args)
        {
            
            int[] arr;
            int sum, highest, lowest;
            double average;
            //assigning values using out parameter method
            IntegerFacts(out arr, out highest, out lowest, out sum, out average);
            //show the results:
            WriteLine("The highest value in the array is: {0}",highest);
            WriteLine("The lowest value in the array is: {0}", lowest);
            WriteLine("The sum of the values in the array: {0}", sum);
            WriteLine("The arithmetic average in the array: {0}", average.ToString());
            WriteLine("Here is the array to compare: ");
            for (int i = 0; i < arr.Length; ++i)
            {
                Write("   {0}   ", arr[i]);
            }

        }
    }
}

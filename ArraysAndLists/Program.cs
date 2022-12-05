using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main()
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] numbersArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            List<int> evens = new List<int>();
            List<int> odds = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            for (int i = 0; i < numbersArray.Length; i++)
            {
                if (numbersArray[i] % 2 == 0)
                {
                    evens.Add(numbersArray[i]);
                }
                else
                {
                    odds.Add(numbersArray[i]);
                }
            }

            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            foreach (var item in evens)
            {
                Console.WriteLine($"{item} is even Stevens");
            }
            foreach (var item in odds)
            {
                Console.WriteLine($"{item} is an odd duck");
            }
        }
    }
}

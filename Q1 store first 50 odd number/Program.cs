using System;

namespace Q1_store_first_50_odd_number
{
    //Write a program that stores first 50 odd numbers to an array
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOdd = new int[25]; //Declaring an array of size 25
            for (int i = 1; i <= 25; i++) //To count from 1 to 25
            {
                arrayOdd[i - 1] = 2 * i - 1; //Using to store odd values to index
            }
            for (int i = 0; i < 25; i++) //To print the array from index 0 to 25
            {
                Console.WriteLine(arrayOdd[i]); // Print Each Index value
            }
        }
    }
}

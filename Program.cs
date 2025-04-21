// Program:    PCAD_Project_3.1.4
// Date:       21 APR 2025
// Programmer: Thomas A. Morrison

using System;
using System.Globalization;
using System.Text;
namespace PCAD_Project_3_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int current;
            int previous;
            int[] array = { 0, 2, 1, 1, 9, 1, 1 };
            int[] newArray = new int[array.Length - 1];

            Console.WriteLine("This program takes an integer array and changes the first two consecutive 1s to 0s.\n");

            Console.Write("Original array:");
            for (int i = 0; i < array.Length; i++) 
            { 
                Console.Write(" " + array[i]);
            }
            Console.WriteLine("\n");

            newArray = ZeroOneOne(array);

            Console.Write("New array:");
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.Write(" " + newArray[i]);
            }
            Console.WriteLine("\n");

            Console.Write("Press any key to continue. ");
            Console.ReadKey();
        }

        static int[] ZeroOneOne(int[] newArray)
        {
            int count = 0;
            int current = 0;
            int previous;
            foreach (int a in newArray)
            {
                previous = current;
                current = a;
                if (previous == 1 && current == 1) 
                {
                    newArray[count] = 0;
                    newArray[count - 1] = 0;
                    break;
                }
                count++;
            }
            return newArray;
        }
    }
}
using System;

namespace task15
{
    class Program
    {

        static void PrintArray(int[] myArray, int i = 0)
        {
            if (i < myArray.Length)
            {
                Console.WriteLine(myArray[i]);
                PrintArray(myArray, i + 1);
            }
        }


        static void Main(string[] args)
        {
            int[] myArray = { 6, 2, 4 };

            PrintArray(myArray);
        }
    }
}
using System;

namespace task16
{
    class Program
    {

        static int Sum(int[] myArray, int i = 0)
        {
            if (i >= myArray.Length)
                return 0;

            int result = Sum(myArray, i + 1);

            return myArray[i] + result;

        }


        static void Main(string[] args)
        {
            int[] myArray = { 5, 3, 2 };

            int result = Sum(myArray);
        }
    }
}
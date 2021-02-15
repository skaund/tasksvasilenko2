using System;

namespace task12
{
    class Program
    {
        static void Resize(ref int[] array, int newSize)
        {
            int[] newArray = new int[newSize];

            for (int i = 0; i < array.Length && 1 < newArray.Length; i++)
            {
                newArray[i] = array[i];
            }

            array = newArray;
        }


        static void Main(string[] args)
        {
            int[] myArray = { 1, 8, 6 };

            Resize(ref myArray, 10);
        }
    }
}
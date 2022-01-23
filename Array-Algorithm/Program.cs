using System;
using System.Collections;

namespace Array_Algorithm
{
    class Program
    {
        static int? LinearSearch(int[] input, int n)
        {
            foreach(int current in input)
            {
                if (n == current)
                {
                    return n;
                }
            }
            return null;
        }

        static Boolean BinarySearch(int[] inputArr, int item)
        {
            int min = 0;
            int max = inputArr.Length - 1;

            while(min <= max)
            {
                int mid = (min + max) / 2;
                if (item == inputArr[mid])
                {
                    return true;
                } 
                else if (item < inputArr[mid])
                {
                    max = mid - 1;
                } 
                else
                {
                    min = mid + 1;
                }
            }
            return false;
        }

        static int[] FindEvenNums(int[] arr1, int[] arr2)
        {
            ArrayList result = new ArrayList();

            foreach(int num in arr1)
            {
                if (num % 2 == 0)
                {
                    result.Add(num);
                }
            }

            foreach (int num in arr2)
            {
                if (num % 2 == 0)
                {
                    result.Add(num);
                }
            }

            return (int[])result.ToArray(typeof(int));
        }

        static int[] Reverse(int[] input)
        {
            int[] reversed = new int[input.Length];

            for (int i=0; i<reversed.Length; i++)
            {
                reversed[i] = input[input.Length - i - 1];
            }

            return reversed;
        }

        static void ReverseInPlace(int[] input)
        {
            for (int i=0; i<input.Length/2; i++)
            {
                int temp = input[i];
                input[i] = input[input.Length - i - 1];
                input[input.Length - i - 1] = temp;
            }
        }

        static void RotateArrayLeft(int[] input)
        {
            int temp = input[0];
            for (int i=0; i<input.Length-1; i++)
            {
                input[i] = input[i + 1];
            }
            input[input.Length - 1] = temp;
        }

        static void RotateArrayRight(int[] input)
        {
            int temp = input[input.Length - 1];
            for (int i=input.Length-1; i>0; i--)
            {
                input[i] = input[i - 1];
            }
            input[0] = temp;
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            RotateArrayLeft(arr);
            RotateArrayRight(arr);
            Array.ForEach(arr, Console.WriteLine);

            Array.ForEach(Reverse(arr), Console.WriteLine);
            ReverseInPlace(arr);
            Array.ForEach(arr, Console.WriteLine);

            int[] arr1 = { -8, 2, 3, -9, 11, -20 };
            int[] arr2 = { 0, -2, -9, -39, 39, 10, 7 };
            int[] evenArr = FindEvenNums(arr1, arr2);
            Array.ForEach(evenArr, Console.WriteLine);

            Console.WriteLine(BinarySearch(arr, 5));
            Array.BinarySearch(arr, 1);

            Console.WriteLine(LinearSearch(arr, 7));
            int item = Array.Find(arr, element => element == 3);
            Console.WriteLine(item);
            int[] items = Array.FindAll(arr, element => element >= 5);
            Array.ForEach(items, Console.WriteLine);
        }
    }
}

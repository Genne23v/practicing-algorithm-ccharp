using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash
{
    class Program
    {
        static List<int> findMissingElements(int[] arr1, int[] arr2)
        {
            List<int> missingElemets = new List<int>();
            HashSet<int> secondArrayItems = new HashSet<int>();

            foreach(int item in arr2)
            {
                secondArrayItems.Add(item);
            }

            foreach(int item in arr1)
            {
                if (!secondArrayItems.Contains(item))
                {
                    missingElemets.Add(item);
                }
            }
            return missingElemets;
        }

        static void displayFrequencyOfEachElement(int[] arr)
        {
            Dictionary<int, int> frequencyDictionary = new Dictionary<int, int>();

            for (int i=0; i<arr.Length; i++)
            {
                if (frequencyDictionary.ContainsKey(arr[i]))
                {
                    frequencyDictionary[arr[i]]++;
                }
                else
                {
                    frequencyDictionary[arr[i]] = 1;
                }
            }

            foreach(KeyValuePair<int, int> x in frequencyDictionary)
            {
                Console.WriteLine(x.Key + " " + x.Value);
            }
        }

        static void main(string[] args)
        {
            displayFrequencyOfEachElement(new int[] {3, 0, 2, 4, 7, 3, 4, 5, 7, 6, 7});

            findMissingElements(new int[] {1, 2, 3, 4}, new int[] {2,4}).ForEach(Console.WriteLine);
            Console.WriteLine();
            findMissingElements(new int[] {3, 2, 8, 4, 5 }, new int[] {5, 7, 3, 0, 2}).ForEach(Console.WriteLine);
        }
    }
}

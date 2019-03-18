using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeConsoleApp
{
    public static class SearchArray
    {
        /// <summary>
        /// Given a sorted ascending array and a number x, find the pair in array whose sum is closest to x
        /// </summary>
        /// <param name="ascArray"></param>
        /// <param name="sumToCompare"></param>
        public static void SearchAscArrayAndPrint(int[] ascArray, int sumToCompare)
        {
            int leftIndex = 0;
            int rightIndex = ascArray.Length - 1;
            int diff = int.MaxValue;
            while (leftIndex < rightIndex)
            {
                if (Math.Abs(ascArray[leftIndex] + ascArray[rightIndex] - sumToCompare) < diff)
                {
                    diff = Math.Abs(ascArray[leftIndex] + ascArray[rightIndex] - sumToCompare);
                }
                if (ascArray[leftIndex] + ascArray[rightIndex] > sumToCompare)
                    rightIndex--;
                else if (ascArray[leftIndex] + ascArray[rightIndex] < sumToCompare)
                    leftIndex++;
                //If closest include situation equal, we need to check the situation. If not, need to remove below 2 lines
                else
                    break;
            }
            Console.WriteLine("The final result is {0} and  {1}", ascArray[leftIndex], ascArray[rightIndex]);
        }
        /// <summary>
        /// Search Array and print all duplicate elements
        /// </summary>
        /// <param name="inputArray"></param>
        public static void SearchArrayPrintDupDict(int[] inputArray)
        {
            //Dictionary
            var dic = new Dictionary<int, int>();
            foreach (var element in inputArray)
            {
                dic[element] = (dic.ContainsKey(element) ? dic[element] : 0) + 1;
            }

            foreach (var pair in dic)
            {
                Console.WriteLine(pair.Key + " repeats " + (pair.Value - 1) + " times when using Dictionary");
            }
        }

        /// <summary>
        /// Search Array and print all duplicate elements
        /// </summary>
        /// <param name="inputArray"></param>
        public static void SearchArrayPrintDupLINQ(int[] inputArray)
        {
            //LINQ
            foreach (var number in inputArray.GroupBy(x => x))
            {
                Console.WriteLine(number.Key + " repeats " + (number.Count() - 1) + " times when using LINQ");
            }
        }
    }
}

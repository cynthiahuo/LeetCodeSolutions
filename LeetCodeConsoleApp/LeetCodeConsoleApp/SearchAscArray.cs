using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeConsoleApp
{
    public static class SearchAscArray
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
    }
}

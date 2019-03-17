using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeConsoleApp
{
    public static class ReverseString
    {
        /// <summary>
        /// Reverse Hello World into World Hello
        /// </summary>
        /// <param name="inputString"></param>
        public static void ReverseHelloWorldString(string inputString)
        {
            string[] tempResult = inputString.Split();
            string outputString = tempResult[1] + " " + tempResult[0];
            Console.WriteLine("The final result is {0}", outputString);
        }

        /// <summary>
        /// Reverse string with more than two words like "Hello World There You Are"
        /// </summary>
        /// <param name="inputString"></param>
        public static void ReverseStrings(string inputString)
        {
            string[] stringArray = inputString.Split();
            Array.Reverse(stringArray);
            string outputString = "";
            for (int i = 0;  i < stringArray.Length; i++)
            {
                outputString = outputString + stringArray[i] + " ";
            }
            Console.WriteLine("The final result is: {0} ", outputString);
        }
    }
}
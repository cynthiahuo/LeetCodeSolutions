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
            string outputString = tempResult[1] +" "+ tempResult[0];
            Console.WriteLine("The final result is {0}", outputString);
        }
    }
}

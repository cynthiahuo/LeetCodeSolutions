using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ////Given a sorted ascending array and a number x, find the pair in array whose sum is closest to x
            //int[] testArray = new int[10] { 1, 1, 3, 3, 4, 5, 6, 8, 19, 29 };
            //int sum = 14;
            //SearchAscArray.SearchAscArrayAndPrint(testArray, sum);
            //Console.ReadLine();

            ////Reverse Hello World to World Hello
            //string orgionalString = "Hello World";
            //ReverseString.ReverseHelloWorldString(orgionalString);
            //Console.ReadLine();

            ////Reverse string with more than two words like "Hello World There You Are"
            string orgionalString = "Hello World There You Are";
            ReverseString.ReverseStrings(orgionalString);
            Console.ReadLine();

            ////Search array and print all duplicate elements
            //int[] inputArray = new int[8] { 4, 3, 2, 7, 8, 2, 3, 1 };
            //SearchArray.SearchArrayPrintDup(inputArray);
            //Console.ReadLine();
        }
    }
}

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
            int[] testArray = new int[10] { 1, 1, 3, 3, 4, 5, 6, 8, 19, 29 };
            int sum = 14;
            SearchAscArray.SearchAscArrayAndPrint(testArray, sum);
            Console.ReadLine();
        }
    }
}

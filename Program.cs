using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace netcentric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program to sort an array using bubble sort

            //initializing an array
            int[] array = { 4, 5, 0, 1, 12, 69, 54, 90, 1002 };

            Console.WriteLine($"Before sorting the array: ");
            foreach (var item in array)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
            Sort sorter = new Sort(array);
            
            var sortedArray = sorter.sortArrayUsingBubbleSort();
            Console.WriteLine($"After sorting the array: ");

            foreach (var item in sortedArray)
            {
                Console.Write(item + "\t");

            }
        }
    }
}

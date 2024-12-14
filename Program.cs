using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netcentric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program to swap two numbers without using third variable

            Console.WriteLine("Enter the first Number");
            int firstNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second Number");
            int secondNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Before Swapping.");
            Console.WriteLine($"First Number = {firstNumber}  , Second Number = {secondNumber}");

            firstNumber = firstNumber + secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber = firstNumber - secondNumber;

            Console.WriteLine("After Swapping.");
            Console.WriteLine($"First Number = {firstNumber}  , Second Number = {secondNumber}");
        }
    }
}

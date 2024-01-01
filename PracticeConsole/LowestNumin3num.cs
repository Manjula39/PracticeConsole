using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    internal class LowestNumin3num
    {
        static void Main()
        {
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            // Method 1: Using Conditional Statements (if-else)
            int minNumber1 = FindMinNumberMethod1(num1, num2, num3);
            Console.WriteLine($"Method 1 - The minimum number is: {minNumber1}");

            // Method 2: Using Math.Min Function
            int minNumber2 = FindMinNumberMethod2(num1, num2, num3);
            Console.WriteLine($"Method 2 - The minimum number is: {minNumber2}");

            // Method 3: Using Array and LINQ
            int minNumber3 = FindMinNumberMethod3(num1, num2, num3);
            Console.WriteLine($"Method 3 - The minimum number is: {minNumber3}");
        }

        // Method 1: Using Conditional Statements (if-else)
        static int FindMinNumberMethod1(int a, int b, int c)
        {
            if (a <= b && a <= c)
            {
                return a;
            }
            else if (b <= a && b <= c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }

        // Method 2: Using Math.Min Function
        static int FindMinNumberMethod2(int a, int b, int c)
        {
            return Math.Min(Math.Min(a, b), c);
        }

        // Method 3: Using Array and LINQ
        static int FindMinNumberMethod3(int a, int b, int c)
        {
            int[] numbers = { a, b, c };
            return numbers.Min();
        }
    }
}
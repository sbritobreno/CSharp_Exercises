using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_week4
{
//    3. Create a method named Sum() that accepts any number of integer parameters and displays
//their sum.Write a Main() method that demonstrates the Sum() method works correctly
//when passed one, three, or five integers, or an array of ten integers.
    public class exercise_3
    {
        // 1 parameter
        public static void Sum(int number1)
        {
            Console.WriteLine($"The sum of {number1} is " + number1 );
        }
        // 3 parameter
        public static void Sum(int number1, int number2, int number3)
        {
            Console.WriteLine($"The sum of {number1}, {number2} and {number3} is " + number1 + number2 + number3);
        }
        // 5 parameter
        public static void Sum(int number1, int number2, int number3, int number4, int number5)
        {
            Console.WriteLine($"The sum of {number1}, {number2}, {number3}, {number4} and {number5} is " 
                + number1 + number2 + number3 + number4 + number5);
        }
        // 1 parameter -> Array
        public static void Sum(int[] intArray)
        {
            var result = 0;

            for(var i = 0; i < intArray.Length; i++)
            {
                result += intArray[i];
            }

            Console.WriteLine("The sum of the numbers " + string.Join(",", intArray) + " is: " + result);

        }
    }
}

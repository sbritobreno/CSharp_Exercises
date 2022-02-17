using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_week2
{
    public class Exercise1
    {
        //Exercise 1:
        /*
         * Build a simple calculator. 
         * Read in two integers from the user 
         * and add them together. 
         * subtract
         * multiply
         * division(display quotient and remainder separately)
         * Print the results in a nice output statement.
         * 
         * 
         * */

        public static string Add(int num1, int num2)
        {
            var r = num1 + num2;
            return $"{num1} + {num2} = {r}";
        }
        public static string Subtract(int num1, int num2)
        {
            var r = num1 - num2;
            return $"{num1} - {num2} = {r}";
        }
        public static string Multiply(int num1, int num2)
        {
            var r = num1 * num2;
            return $"{num1} * {num2} = {r}";
        }
        public static string Division(int num1, int num2)
        {
            var r = num1 / num2;
            return $"{num1} / {num2} = {r}";
        }
        public static string Remainder(int num1, int num2)
        {
            var r = num1 % num2;
            return $"{num1} % {num2} = {r}";
        }

    }
}

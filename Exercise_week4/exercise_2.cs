using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_week4
{
//    2. Create a console-based program whose Main() method prompts the user for an integer
//value and, in turn, passes the value to a method that squares the number and to a method
//that cubes the number.The Cube() method should call the Square() method. The Main()
//method displays the results returned from each of the other methods.
    public class exercise_2
    {
        public static void Cube(int number)
        {
            Console.WriteLine($"The cube of {number} is " + number * number * number);
            Square(number);
        }
        public static void Square(int number)
        {
            Console.WriteLine($"The square of {number} is " + number * number);
        }
    }
}

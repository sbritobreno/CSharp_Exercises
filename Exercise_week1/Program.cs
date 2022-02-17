using Exercise_week2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_week2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            Console.WriteLine("### Exercise 1 ###");

            Console.WriteLine("Enter the first number");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(Exercise1.Add(firstNumber, secondNumber));
            Console.WriteLine(Exercise1.Subtract(firstNumber, secondNumber));
            Console.WriteLine(Exercise1.Multiply(firstNumber, secondNumber));
            Console.WriteLine(Exercise1.Division(firstNumber, secondNumber));
            Console.WriteLine(Exercise1.Remainder(firstNumber, secondNumber));

            Console.WriteLine("\nPress ENTER to go to next exercise...");
            Console.ReadLine();

            //Exercise 2
            Console.WriteLine("### Exercise 2 ###");

            Console.WriteLine("Enter the length");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine(Exercise2.CarpertingPrice(length, width));
        }
    }
}


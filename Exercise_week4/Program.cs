using System;
using System.Collections.Generic;

namespace Exercise_week4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            Console.WriteLine("Exercise 1...");
            Console.WriteLine("Enter a number to be multiplied by the number 2 to 10.");
            var input1 = int.Parse(Console.ReadLine());
            exercise_1.MultiplicationTable(input1);
            Console.ReadKey();

            //Exercise 2
            Console.WriteLine("\nExercise 2...");
            Console.WriteLine("Enter a number, we will show you its cube and square value");
            var input2 = int.Parse(Console.ReadLine());
            exercise_2.Cube(input2);
            Console.ReadLine();

            //Exercise 3
            Console.WriteLine("\nExercise 3...");
            List<int> numbers = new List<int>();

            Console.WriteLine("enter first number");
            var number1 = int.Parse(Console.ReadLine());
            numbers.Add(number1);

            Console.WriteLine("enter second number");
            var number2 = int.Parse(Console.ReadLine());
            numbers.Add(number2);

            Console.WriteLine("enter third number");
            var number3 = int.Parse(Console.ReadLine());
            numbers.Add(number3);

            var numbersArray = numbers.ToArray();
            exercise_3.Sum(numbersArray);  // Passing an Array
            Console.ReadLine();
            Console.WriteLine("\nFinish...");
        }
    }
}

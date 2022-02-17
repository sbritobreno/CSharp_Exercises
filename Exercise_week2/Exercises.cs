using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_week3
{
    public class Exercises
    {
        //1. Write a console-based application that prompts a user for an hourly pay rate. While the user
        //enters values less than $5.65 or greater than $49.99, continue to prompt the user.Before the
        //program ends, display the valid pay rate.

        public static void Exer1()
        {
            var minPayRate = 5.65;
            var maxPayRate = 49.99;

            for (int i = 0; i<3; i++)
            {
                Console.WriteLine("Enter an hourly pay rate:");
                var input = double.Parse(Console.ReadLine());

                if(input < minPayRate || input > maxPayRate)
                {
                    Console.WriteLine("Incorrect Value");
                } 
                else {
                    Console.WriteLine($"The hourly pay rate is from {minPayRate} to {maxPayRate} and you have enter {input}");
                    break;
                }
            }
            Console.WriteLine($"\nThe hourly pay rate is from {minPayRate} to {maxPayRate}");
        }

        //2. Write a console-based application that sums the integers from 1 to 50.
        public static void Exer2()
        {
            var sum = 0;
            for (int i = 1; i <= 50; i++)
            {               
                sum += i;
            }
            Console.WriteLine($"The Answer for exercise 2 is: {sum}");
        }

        //3. Write a program that generates a random number between 1 and 10. Ask a user to guess the
        //random number, then display the random number and a message indicating whether the user's
        //guess was too high, too low, or correct.

        public static void Exer3()
        {
            Random random = new Random();
            int randomNo = random.Next(11);

            while (true)
            {
                Console.WriteLine("Try to guess the random number from 1 to 10: ");
                var input = int.Parse(Console.ReadLine());

                if (input == randomNo)
                {
                    Console.WriteLine($"that is right :) random number is {randomNo}");
                    break;
                }
            }
        }
    }
}

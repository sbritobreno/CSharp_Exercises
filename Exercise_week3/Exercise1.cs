using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise__week3
{
    //    1. Write a program for a package delivery service.The program contains an array that holds the
    //    ten zip codes to which the company delivers packages. Prompt a user to enter a zip code and
    //    display a message indicating whether the zip code is one to which the company delivers.

    public class Exercise1
    {
        public static void Exer1()
        {
            Console.WriteLine("\nExercise 1\n");
            string[] zipCodes = new string[10] { "D01", "D02", "D03", "D04", "D05", "D06", "D07", "D08", "D09", "D010" };
        
            Console.WriteLine("Enter a zip code and we will check if the company deliveries at this location:");
            var input = Console.ReadLine();
            bool delivery = false;

                foreach( var z in zipCodes)
                {
                if (z == input)
                    delivery = true;
                }

            if (delivery)
                Console.WriteLine($"WE do delivery at {input} zip code...");
            else {
                Console.WriteLine("WE only delivery at the following zip codes:");
                foreach(var z in zipCodes)
                {
                    Console.Write(z + "; ");
                }

            }
        }
    }
}

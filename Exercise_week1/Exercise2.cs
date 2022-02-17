using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_week2
{
    public class Exercise2
    {
        //Exercise 2
        /*
         * Write a program that asks the user for the length and width of their room. Define a constant
         * that represents the price of carpeting per square foot. Compute and display the cost of carpeting the room.
         * 
         * */

        public static string CarpertingPrice(int length, int width)
        {
            var squareMeter = length * width;
            var squareFoot = Math.Round(squareMeter * 10.7639, 2);

            const double pricePerSquareFoot = 1.99;

            var result = Math.Round(squareFoot * pricePerSquareFoot, 2);

            return $"The total price for carperting {squareFoot} squareFoot is {result} euro";
        }
    }
}

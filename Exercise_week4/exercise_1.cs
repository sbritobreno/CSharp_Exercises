using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_week4
{
//    1. Create a console-based application whose Main() method asks the user to input an integer
//and then calls a method named MultiplicationTable(), which displays the results of
//multiplying the integer by each of the numbers 2 through 10.
    public class exercise_1
    {
        public static void MultiplicationTable(int number)
        {
            int i = 2;
            while(i <= 10)
            {
                var result = number * i;
                Console.WriteLine($"{number} x {i} = {result}");
                i++;    
            }
        }
    }
}

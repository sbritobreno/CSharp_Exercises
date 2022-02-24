using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_week5
{
//    1. Create a class named Square that contains fields for area and the length of a side and whose
//constructor requires a parameter for the length of one side of a Square.The constructor
//assigns its parameter to the length of the Square’s side field and calls a private method that
//computes the area field.Also include read-only properties to get a Square’s side and area. In
//the main method create an array of ten Square objects with sides that * have values of 1
//through 10. Display the values for each Square.

    public class Exercise_1
    {
        public static void DoExercise()
        {
            Console.WriteLine("Exercise 1\n");

            Square[] areas = new Square[10];

            for(int i = 0; i<10; i++)
            {
                areas[i] = new Square(i + 1);
            }
            foreach(var a in areas)
                Console.WriteLine(a.ToString());
        }
    }
    public class Square
    {
        private readonly float _lenght;
        private float _area;

        public Square(float lenght)
        {
            _lenght = lenght;
            AreaField(_lenght);
        }
        private void AreaField(float lenght)
        {
            _area = lenght * lenght;
        }
        public override string ToString()
        {
            return $"Area with lenght = {_lenght} has area = {_area}...";
        }
        public float Lenght
        {
            get
            {
                return _lenght;
            }
        }
        public float Area
        {
            get
            {
                return _area;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise__week3
{
    //    2. Write a program that allows a teacher to enter in a N-number of students.For each student
    //ask the teacher to enter in their name and final score for the class. When the teacher is done
    //entering the data, print the highest grade in the class, and the average grade for the class.

    public class Exercise2
    {
        public class Student
        {
            public string _name;
            public float _score;

            public Student(string name, float score)
            {
                _name = name;
                _score = score;
            }
            public override string ToString()
            {
                return $"Student: {_name} / Score: {_score}";
            }
        }

        public static void Exer2()
        {
            Console.WriteLine("\n\nExercise 2\n");

            List<Student> studentsList = new List<Student>();

            while (true)
            {
                Console.WriteLine("Enter the name of the student or press ENTER to exit... ");
                var studentName = Console.ReadLine();

                if (studentName == "")
                    break;

                Console.WriteLine("Enter the student score: ");
                var studentScore = float.Parse(Console.ReadLine());

                studentsList.Add(new Student(studentName, studentScore));
            }

            if (studentsList.Count() != 0)
            {
                var higherScoreStudent = studentsList.First();
                float higherScore = higherScoreStudent._score;

                foreach (var s in studentsList)
                {
                    if (s._score > higherScore)
                    {
                        higherScoreStudent = s;
                    }
                }

                Console.WriteLine("Student with the higher score is : " + higherScoreStudent.ToString());
            }else
                Console.WriteLine("No students in the list...");
        }
    }
}

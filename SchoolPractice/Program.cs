using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student bethany = new Student("Bethany", 1, 1, 4.0);
            Console.WriteLine("The Student class works! " + bethany.Name + " is a student!" + bethany.Name + "'s student ID number is " + bethany.StudentId + ". She has " + bethany.NumberOfCredits + " credit(s) and her GPA is " + bethany.Gpa + "!");
        }
    }
}

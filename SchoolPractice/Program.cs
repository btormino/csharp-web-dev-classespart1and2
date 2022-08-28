using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student bethany = new Student("Bethany", 1, 1, 4.0);
            Teacher steve = new Teacher("Steve", "Thomas", "Math", 12);
            //Course math = new Course("Math", )

            Console.WriteLine("The Student class works! " + bethany.Name + " is a student! " + bethany.Name + "'s student ID number is " + bethany.studentId + ". She has " + bethany.NumberOfCredits + " credit(s) and her GPA is " + bethany.Gpa + "!");
           
            Console.WriteLine("The Teacher class works! " + steve.FirstName + steve.LastName + "is a teacher! " + steve.FirstName + " teaches " + steve.Subject + " and has for " + steve.YearsTeaching + ".");
            
        }
    }
}

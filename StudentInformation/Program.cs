using System;

namespace StudentInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a response!");
            Console.WriteLine("Enter your name:");
            // Get the student's name
            string name = Console.ReadLine();

            Console.WriteLine("Enter roll number!");
            // Get student's roll number
            string rollNumber = Console.ReadLine();

            Console.WriteLine("Enter your age");
            // Get student's age
            string age = Console.ReadLine();

            Console.WriteLine("Enter your class");
            // Get student's class
            string studentClass = Console.ReadLine();

            Console.WriteLine("Enter your university name:");
            // Get student's university name
            string university = Console.ReadLine();

            Console.WriteLine($"Student Information\nName: {name} \nRoll No: {rollNumber} \nAge: {age} \nClass: {studentClass} \nUnivers{university}");
        }
    }
}

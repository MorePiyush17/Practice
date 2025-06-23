using System;
namespace StudentGradingMarks
{
    internal class Student
    {
        public string StudentName { get; }
        public string RollNumber { get; }
        public int[] Marks { get; }

        public Student(string studentName, string rollNumber, int[] marks)
        {
            if (marks == null || marks.Length != 5)
                throw new ArgumentException("Marks must be an array of exactly 5 integers.");

            StudentName = studentName;
            RollNumber = rollNumber;
            Marks = marks;
        }

        public double CalculateAverage()
        {
            double sum = 0;
            foreach (int mark in Marks)
            {
                sum += mark;
            }
            return sum / Marks.Length;
        }

        public string CalculateGrade()
        {
            double average = CalculateAverage();
            if (average >= 90)
                return "A+";
            else if (average >= 80)
                return "A";
            else if (average >= 70)
                return "B+";
            else if (average >= 60)
                return "B";
            else if (average >= 50)
                return "C+";
            else if (average >= 40)
                return "C";
            else
                return "Fail";
        }

        public void PrintReport()
        {
            double average = CalculateAverage();
            string grade = CalculateGrade();
            Console.WriteLine("Student Report Card");
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Name        : {StudentName}");
            Console.WriteLine($"Roll No     : {RollNumber}");
            Console.WriteLine($"Marks       : [{string.Join(", ", Marks)}]");
            Console.WriteLine($"Average     : {average:F1}");
            Console.WriteLine($"Grade       : {grade}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
    
            string name = "Swapnil Kulkarni";
            string rollNumber = "R102";
            int[] marks = { 78, 85, 90, 88, 76 };

       
            Student student = new Student(name, rollNumber, marks);
            student.PrintReport();
        }
    }
}ss
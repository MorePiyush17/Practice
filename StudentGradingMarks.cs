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
        public override string ToString()
        {
            string marksStr = string.Join(", ", Marks);
            double average = CalculateAverage();
            string grade = CalculateGrade();

            return $"Student Report Card\r\nName: {StudentName}\nRoll Number: {RollNumber}\nMarks: {marksStr}\nAverage: {CalculateAverage():F2}\nGrade: {CalculateGrade()}";
        }

    }
        internal class Program
        {

            static void Main(string[] args)
            {
                var student = new Student("Swapnil Kulkarni", "12345", new int[] { 85, 90, 78, 92, 88 });



                Console.WriteLine(student.ToString());
            }
        }
    }


namespace StudentGradingSystem
{
    internal class Student
    {
        public string Name { get; set; }
        public int Marks { get; set; }
        public char Grade { get; set; }

        //constructor with only name
        public Student(string name)
        {
            Name = name;
            Marks = 0;
            Grade = 'D';

        }
        // constructor with name and marks
        public Student(string name, int marks)
        {
            Name = name;
            Marks = marks;
            Grade = 'D';
        }
        // Constructor with name, marks and grade

        public Student(string name, int marks, char grade)
        {
            Name = name;
            Marks = marks;
            Grade = grade;

        }

        //assign grade method
        public void AssignGrade()
        {
            if (Marks >= 90)
                Grade = 'A';
            else if (Marks >= 80)
                Grade = 'B';
            else if (Marks >= 70)
                Grade = 'C';
            else if (Marks >= 60)
                Grade = 'D';
            else
                Grade = 'F';
        }
        // Displayinfo method 
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Marks: {Marks}, Grade: {Grade}");

        }
    }


        internal class Program
        {
            static void Main(string[] args)
            {
                //student with only name
                Student student1 = new Student("Alice");
                student1.Marks = 95;
                student1.AssignGrade();
                student1.DisplayInfo();

            //student with only name
                Student student2  = new Student("Bob", 85);
                student2.AssignGrade();
                student2.DisplayInfo();


                //student with only name
                Student student3 = new Student("Charlie", 75, 'X');
                student3.AssignGrade();
                student3.DisplayInfo();
            }
        }
    }
    


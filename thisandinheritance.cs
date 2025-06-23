using System;
namespace thisandinheritance
{

    class Shape
    {

        public virtual double GetArea()
        {
            return 0;
        }
    }

    // derived class using 'this' keyword
    class Circle : Shape
    {
        private const double pi = 3.14;
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double GetArea()
        {
            return pi * radius * radius;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Console.Write($"Circle.area: {circle.GetArea()}");




    }
    }
}



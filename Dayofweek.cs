using System;

enum Day
{  Sunday ,Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number (1-7): ");
        if (int.TryParse(Console.ReadLine(), out int input) && input >= 1 && input <= 7)
        {
            Day day = (Day)(input);
            Console.WriteLine($"The day is: {day}");
        }
        else
        {
            Console.WriteLine("Invalid input. Enter number between 1 - 7: ")
               
                }
         }
            
}
      




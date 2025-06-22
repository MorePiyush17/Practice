namespace StringManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Sachin, Aurionpro, Mumbai";

            //split of string 
            string[] parts = input.Split(',');

            //display output

            Console.WriteLine("Developer Name: " + parts[0]);
            Console.WriteLine("Comapny name is : " + parts[1]);
            Console.WriteLine("Location is : " + parts[2]);

        }
    }
}

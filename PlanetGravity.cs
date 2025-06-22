namespace PlanetGravity
{
    enum Planet {      
        Mercury,
        Venus,
        Earth,
        Mars,
        Jupiter,
        Saturn,
        Uranus,
        Neptune
    }

    internal class Program
    {
        //Gravity relative to Earth for each planet
        static double[] gravity = { 0.38, 0.91, 1.00, 0.38, 2.34, 1.06, 0.92, 1.19 };

        static void Main(string[] args)
        {
            Console.Write("Enter Earth weight: ");
            if (double .TryParse(Console.ReadLine(), out double earthweight) && earthweight > 0)
            {
                for (int i = 0; i< Enum.GetNames(typeof(Planet)).Length; i++)
                {
                    Planet planet = (Planet)i;
                    double Planetweigth = earthweight * gravity[i];
                    if (planet != Planet.Earth)
                    {
                        Console.WriteLine($"Weight on {planet}: {Planetweigth}kg ");

                    }

                }
              
            }
        }
    }
}

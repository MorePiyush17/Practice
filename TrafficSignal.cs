namespace TrafficSignal
{

    enum TrafficLight
    {
        RED, YELLOW, GREEN
    }

    internal class Program
    {

        static void DriverAction(TrafficLight signal)
        {
            switch (signal)
            {
                case TrafficLight.RED:
                    Console.WriteLine("Signal: RED : Stop");
                    break;
                case TrafficLight.GREEN:
                    Console.WriteLine("Signal: GREEN : Go");
                    break;
                case TrafficLight.YELLOW:
                    Console.WriteLine("Signal: YELLOW : GetReady");
                    break;
            }
        }

        static void Main(string[] args)
        {

            DriverAction(TrafficLight.RED);
            DriverAction(TrafficLight.GREEN);
            DriverAction(TrafficLight.YELLOW);
        }
    }
}
using System;

namespace FunctionsandArray
{
    class Program
    {
        static double[] ApplyDiscount(double[] fees)
        {
            double[] finalFees = new double[fees.Length];
           
            for (int i = 0; i < fees.Length; i++)
            {
            if (fees[i] > 7000)
                {
                 finalFees[i] = fees[i] - (fees[i] * 0.05); 
              }

             if (fees[i] <= 7000)
                  {
                finalFees[i] = fees[i];
             }
         }

            return finalFees;
        }

        static void Main()
        {
          double[] studentFees = new double[4]; 
            for (int i = 0; i < 4; i++)
               {
                double fee;

             do
              {
                Console.Write("Enter fees for Student " + (i + 1) + " : ");
                fee = Convert.ToInt32(Console.ReadLine());

                if (fee < 5000 || fee > 10000)                     {
                Console.WriteLine("Error! Fees must be in range 5000 to 10000");
                    }

                  } while (fee < 5000 || fee > 10000);

                studentFees[i] = fee;
               }
         
            double[] finalFees = ApplyDiscount(studentFees);

            Console.WriteLine("\n Fees with discount are:");
            for (int i = 0; i < finalFees.Length; i++)
            {
                Console.WriteLine("Student " + (i + 1) + " : " + finalFees[i]); 
            }
        }
    }
}

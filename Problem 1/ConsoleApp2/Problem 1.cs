using System;

namespace ConsoleApp2
{
    class Problem1
    {
        

        public static void Problem()
        {
            int multiplesOf3 = 0;
            int multiplesOf3Sum = 0;
            int multiplesOf5 = 0;
            int multiplesOf5Sum = 0;
            int multiplesOf15 = 0;
            int multiplesOf15Sum = 0;
            int b = 3;
            int c = 5;
            int d = 15;
            int j = 0;
            for (j = 1; j< 100000; j++)
            {   


                multiplesOf3 = b * j;
                multiplesOf5 = c * j;
                multiplesOf15 = d * j;
                if (multiplesOf3 < 1000)
                {
                    
                    multiplesOf3Sum = multiplesOf3 + multiplesOf3Sum;
                    Console.WriteLine(multiplesOf3);                   
                }

                if (multiplesOf5 < 1000)
                {
                    multiplesOf5Sum = multiplesOf5 + multiplesOf5Sum;
                    Console.WriteLine(multiplesOf5);
                }
                if (multiplesOf15 < 1000)
                {
                    multiplesOf15Sum = multiplesOf15 + multiplesOf15Sum;
                    Console.WriteLine(multiplesOf15);
                   
                }


            }
            Console.WriteLine("Sum of muliples of 3: " + multiplesOf3Sum);
            Console.WriteLine("Sum of muliples of 5: " + multiplesOf5Sum);
            Console.Write("Final Sum is : " + (multiplesOf3Sum + multiplesOf5Sum - multiplesOf15Sum));
            Console.ReadKey();

        }
    }
}

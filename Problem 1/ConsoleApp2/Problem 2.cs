using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Problem2
    {
        public static void Problem2nd()
        {
            List<int> test = new List<int>();
            test.Add(1);
            test.Add(2);
            int n = 4000000;
            int result = 0;
            int FinalResult = 2;
            for (int i = 2; test[i - 1] < n; i++)
            {
                result = test[i - 2] + test[i - 1];
                test.Add(result);

                if(result % 2 == 0)
                {
                    FinalResult = FinalResult + result;
                }
                
            }
            Console.WriteLine(FinalResult);
            
           










           
                
            
        }
    }
}

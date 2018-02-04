using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Problems");
            Console.WriteLine("1. Problem 1");
            Console.WriteLine("2. Problem 2");
            Console.WriteLine("3. Problem 3");

            int choice=Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
                Problem1.Problem();
            if (choice == 2)
                Problem2.Problem2nd();
            if (choice == 3)
                Problem3.Problem3rd();


            Console.ReadKey();
        }
    }
}

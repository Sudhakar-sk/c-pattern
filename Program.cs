using System;

namespace pattern
{
    class Program
    { 
        static void starpattern(){

        int n=Convert.ToInt32(Console.ReadLine());//getting input from user
      //core logic
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        //core logic
        }
        static void Main()//main method
        {
            Console.WriteLine("Enter the number of row here....");
            starpattern(); //starpattern method called here

            Console.ReadKey(); //waiting for any key to terminate program
        }
    }
}


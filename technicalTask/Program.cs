using System;

namespace technicalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number:");
            int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(n);

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
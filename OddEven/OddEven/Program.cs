using System;

namespace OddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Program.OddEven(y);
        }
        public static void OddEven(int num)
        {

            if (num % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
        }
    }
}

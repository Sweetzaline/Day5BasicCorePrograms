using System;

namespace PowerOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the exponential number: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Program.PoweroTwo(y);
        }
        public static void PoweroTwo(int num)
        {

            int temp = num;
            int answer = 1;
            while(num != 0)
            {
                answer = answer * 2;
                num = num - 1;
            }
            Console.WriteLine($"Power of 2 ^ {temp} is: {answer}");
           
        }
    }
}

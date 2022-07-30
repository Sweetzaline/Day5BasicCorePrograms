using System;

namespace Harmonic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Program.HarmonicNo(y);
        }

        public static void HarmonicNo(int num)
        {
            double answer = 0;
            for(int i =1; i<=num; i++)
            {
                answer = (answer + 1) / i;
            }
            Console.WriteLine($"Harmonic No. = {answer}");
        }
    }
}

using System;

namespace LargestAmongthree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            
            int largest = num1;
            int[] a = { num1, num2, num3 };
            foreach (var b in a)
            {
                if (b > largest)
                {
                    largest = b;
                }
            }
           
           Console.WriteLine("Largest Number is " +largest);
        }
    }
}

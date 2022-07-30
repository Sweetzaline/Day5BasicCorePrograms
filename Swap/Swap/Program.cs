using System;

namespace Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"First No.= {a} and Second No.= {b} ");
        }
    }
}

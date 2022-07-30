using System;

namespace QuotientRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Divisor ");
            int Divisor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Dividend ");
            int Dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Quotient is: {Dividend / Divisor}");
            Console.WriteLine($"Remainder is: {Dividend % Divisor}");
        }
    }   
}

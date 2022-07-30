using System;

namespace LeapYear
{
    public class LY
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the year: ");
            int y = Convert.ToInt32(Console.ReadLine());
            LY.LeapYear(y);

        }
        public static void LeapYear(int year)
        {

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine($"{year} is a Leap Year");
            }
            else
            {
                Console.WriteLine($"{year} is not a Leap Year");
            }
        }       
    }
}

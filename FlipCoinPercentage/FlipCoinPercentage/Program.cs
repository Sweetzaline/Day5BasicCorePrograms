using System;

namespace FlipCoinPercentage
{
    public class FlipCoin
    {
        static int HeadCount = 0;
        static int TailCount = 0;
        public static void FlipCoinMethod(int userinput)
        {
            int temp = userinput;
            Random r = new Random();
            while (userinput != 0)
            {
                double random = r.NextDouble();
                if (random <= 0.5)
                {
                    TailCount = TailCount + 1;
                }
                else
                {
                    HeadCount++;
                }
                userinput = userinput - 1;
            }
            Console.WriteLine((HeadCount * 100) / temp);
            Console.WriteLine((TailCount * 100) / temp);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the coin flip= ");
            int flip = Convert.ToInt32(Console.ReadLine());
            FlipCoin.FlipCoinMethod(flip);
        }
    }
}

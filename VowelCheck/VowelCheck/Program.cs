using System;

namespace VowelCheck
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Alphabet: ");
            char c;
            c = Console.ReadKey().KeyChar;

            if (c == 'a' || c == 'A' || c == 'e' || c == 'E' || c == 'i' || c == 'I' || c == 'o' || c == 'O' || c == 'u' || c == 'U')
            {
                Console.WriteLine(", is Vowel");
            }
            else
            {
                Console.WriteLine(",  is a Consonant");
            }
        }
    }
}

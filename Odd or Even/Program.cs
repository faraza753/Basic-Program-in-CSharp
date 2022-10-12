using System;

namespace Odd_or_Even
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter the number to check it is odd or even");
            i = Convert.ToInt32(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.Write("Number is Even"  +   i);
            }
            else
            {
                Console.Write("Number is Odd"   +   i);
            }
        }
    }
}

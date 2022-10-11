using System;

namespace Reverse
{
    class Reverse
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            int r, pal = 0,temp;

            temp = n;
            while (n != 0)
            {
                r = n % 10;
                pal = pal * 10 + r;
                n = n / 10;

            }
            if(temp == pal)
                Console.WriteLine("Number is Palindrome");
            else 
                Console.WriteLine("Number is not palindrome");

        }
    }
}

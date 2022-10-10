using System;

namespace AdditionOfDigits
{
    class Addofdigit
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int temp, r, sum = 0;
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = sum + r;
                n = n / 10;
            }
            Console.WriteLine(sum);
        }
    }
}

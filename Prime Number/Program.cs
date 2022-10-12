using System;

namespace Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number to check number is prime or not");
            int n = Convert.ToInt32(Console.ReadLine());
            bool isprime = true;
            for (int i = 2; i < n/2; i++)
            {
                if (n % i == 0)
                {
                    isprime = false;
                }
            }
            if (isprime)
            {
                Console.Write("Number is prime");
            }
            else
            {
                Console.Write("Number is not prime");
            }
        }
    }
}

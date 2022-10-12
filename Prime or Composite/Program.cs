using System;

namespace Prime_or_Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n, c=0;
            Console.Write("Enter the number to check number is prime or composite");
            n= Convert.ToInt32(Console.ReadLine());
            for(i=1;i<=n;i++)
            {
                if (n % i == 0)
                    c = c + 1;
            }
            if (c == 2)
                Console.WriteLine("THe number is prime");
            else
                Console.WriteLine("The number is composite");
            return ;
        }
    }
}

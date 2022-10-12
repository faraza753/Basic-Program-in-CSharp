using System;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            long   j = 1;
            Console.Write("Enter the number");
            n=Convert.ToInt32(Console.ReadLine());
            for(i=1;i<=n;++i)
            {
                j = j*i; 

            }
            Console.Write("Factorial of" + n + "is" + j);

        }
    }
}

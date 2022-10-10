using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Armstrong
{
    class Armstrong
    {
        public static void Main(String[] args)
        {

            int r, sum = 0, temp;
            int n = Convert.ToInt32(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = sum + (r * r * r);
                n = n / 10;



            }
            if (temp == sum)
                Console.WriteLine("armstrong number");
            else
                Console.WriteLine("not armstrong");
            return;

        }
    }
}

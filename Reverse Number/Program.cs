﻿using System;

namespace Reverse
{
    class Reverse
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int r, rev = 0;
            while (n != 0)
            {
                r = n % 10;
                rev = rev * 10 + r;
                n = n / 10;

            }
            Console.WriteLine(rev);
        }
    }
}

using System;

namespace Basics_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int i, j;
            int[,] arr1 = new int[3, 3];
            int[,] arr2 = new int[3, 3];
            int[,] arr3 = new int[3, 3];


            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }
            Console.Write("\n");

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }
            Console.Write("\n");

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    arr3[i, j] = arr1[i, j] + arr2[i, j];

                }
            }



            for (i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 3; j++)
                {
                    Console.Write("\t{0}\t   ", arr1[i, j]);

                }
            }
            Console.Write("\n");
            Console.Write("\n");
            Console.Write("\t\t\t+\t");
            Console.Write("\n");
            Console.Write("\n");
            for (i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 3; j++)
                {
                    Console.Write("\t{0}\t   ", arr2[i, j]);

                }
            }
            Console.Write("\n");
            Console.Write("\n");
            Console.Write("\t\t\t=\t");
            Console.Write("\n");
            Console.Write("\n");
            for (i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 3; j++)
                {
                    Console.Write("\t{0}\t   ", arr3[i, j]);

                }
            }
            Console.ReadKey();
        }
    }
}

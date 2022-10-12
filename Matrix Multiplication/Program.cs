using System;

namespace Matrix_Multiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, k, n;
            int[,] arr1 = new int[5, 5];
            int[,] arr2 = new int[5, 5];
            int[,] arr3 = new int[5, 5];

            Console.WriteLine("Enter the value of square matrix not more than 5");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value of 1st Matrix");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                {
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("\n");
            Console.WriteLine("Enter value of 2nd Matrix");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                {
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                {
                    arr3[i, j] = 0;
                    for (k = 0; k < n; k++)
                    {

                        arr3[i, j] = arr3[i, j] + arr1[i, k] * arr2[k, j];
                    }
                }
            }
            Console.Write("\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                {
                    Console.Write("\t{0}\t", arr1[i, j]);
                }
            }
            Console.Write("\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                {
                    Console.Write("\t{0}\t", arr2[i, j]);

                }

            }
            Console.Write("\n");
            Console.WriteLine("Multiplication of Matrix is");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                {
                    Console.Write("\t{0}\t", arr3[i, j]);
                }
            }
        }
    }
}

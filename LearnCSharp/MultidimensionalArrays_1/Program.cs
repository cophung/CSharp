//Mảng đa chiều

using System;

namespace MultidimensionalArrays_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] x = new int[2, 3];
            int[,] y = new int[2, 3] { { 1, 2, 3 }, { 2, 3, 4 } };
            for (int i = 0; i < y.GetLength(0); i++)
            {
                for (int j = 0; j < y.GetLength(1); j++)
                {
                    Console.WriteLine($"{i}, {j}, value: {y[i,j]}");
                }
            }
            Console.ReadLine();
        }
    }
}

using System;

namespace Iterate_2D_and_Jagged_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] grades =
              {
                new int[] {5, 4, 7, 3},
                new int[] {7, 3, 2, 6, 7, 4, 2, 4},
                new int[] {5, 3, 7, 3}
            };

            Console.WriteLine(grades.Length);
            Console.WriteLine(grades[0].Length);
            Console.WriteLine(grades.Length);
            Console.WriteLine(grades[1].Length);

            for (int i = 0; i < grades.Length; i++)
            {
                for (int k = 0; k < grades[i].Length; k++)
                {
                    Console.Write(grades[i][k] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int[,] oceny =
             {
                 {5, 4, 7, 3},
                 {7, 3, 2, 6},
                 {5, 3, 7, 3}
            };
            Console.WriteLine(oceny.GetLength(0));
            Console.WriteLine(oceny.GetLength(1));

            for (int i = 0; i < oceny.GetLength(0); i++)
            {
                for (int k = 0; k < oceny.GetLength(1); k++)
                {
                    Console.Write(oceny[i, k] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

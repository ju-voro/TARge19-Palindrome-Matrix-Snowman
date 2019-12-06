using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {

            int[][] matrix =
            {
                new int[] {1, 2, 3}, //row 0
                new int[] {4, 5, 6}, //row 1
                new int[] {7, 8, 9}  //row 2
            };

            Console.WriteLine(matrix[1][1]);

            //Main diagonal 1, 5, 9
            for (int i = 0; i < matrix.Length; i++)
            {
                Console.Write(matrix[i][i]);
            }
            Console.WriteLine();

            //Secondary diagonal 3, 5, 7
            for(int i = 0; i <matrix.Length; i++)
            {
                Console.Write(matrix[i][matrix.Length - 1 - i]);
            }

            Console.WriteLine("Reversed main diagonal");
            //9, 5, 1

            for(int i = matrix.Length -1; i>-1; i--)
            {
                Console.Write(matrix[i][i]);
            }

            Console.WriteLine("Reversed main diagonal, Version 2");
            //9, 5, 1

            for(int i = matrix.Length; i > 0; i--)
            {
                int j = i - 1;
                Console.WriteLine(matrix[i-1][j]);
            }


            //Get diagonals: a) 7, 5, 3 

            for(int i = matrix.Length; i > 0; i--)
            {
                int j = matrix.Length - i;
                Console.WriteLine(matrix[i - 1][j]);
            }

            Console.WriteLine("minor reversed 7, 5, 3");
            for (int i = 0; i < matrix.Length; i++)
            {
                Console.Write(matrix[matrix.Length - 1 - i][i]);
            }

            Console.WriteLine("main reversed 9, 5, 1");
            for (int i = 0; i < matrix.Length; i++)
            {
                Console.Write(matrix[matrix.Length - 1 - i][matrix.Length - 1 - i]);
            }

            Console.ReadKey();
        }
    }
}

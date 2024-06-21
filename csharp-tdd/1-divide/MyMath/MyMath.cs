using System;

namespace MyMath
{
    /// <summary>
    /// Provides operations for matrices.
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// Divides each element of the matrix by the specified number.
        /// </summary>
        /// <param name="matrix">The matrix to be divided.</param>
        /// <param name="num">The number by which each element of the matrix will be divided.</param>
        /// <returns>A new matrix with each element divided by the specified number, or <c>null</c> if the input matrix is <c>null</c> or if <paramref name="num"/> is 0.</returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null)
            {
                return null;
            }

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    try
                    {
                        result[i, j] = matrix[i, j] / num;
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Num cannot be 0");
                        return null;
                    }
                }
            }

            return result;
        }
    }
}

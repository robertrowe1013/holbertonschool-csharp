using System;

namespace MyMath
{
    /// <summary>
    /// maths
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// divide matrix
        /// </summary>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null)
            {
                return (null);
            }
            int len0 = matrix.GetLength(0);
            int len1 = matrix.GetLength(1); 
            int[,] newMatrix = new int[len0, len1];

            for (int i = 0; i < len0; i++)
            {
                for (int i2 = 0; i2 < len1; i2++)
                {
                    try
                    {
                        newMatrix[i, i2] = matrix[i, i2] / num;
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Num cannot be 0");
                        return (null);
                    }
                }
            }

            return (newMatrix);
        }
    }
}

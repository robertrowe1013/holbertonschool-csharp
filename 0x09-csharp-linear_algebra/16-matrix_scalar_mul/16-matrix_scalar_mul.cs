using System;

/// <summary>
///  matrix math
/// </summary>
class MatrixMath
{
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            double[,] matrix = new double[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    matrix[i, j] = matrix1[i, j] * scalar;
                }
            }
            return (matrix);
        }
        else if (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3)
        {
            double[,] matrix = new double[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = matrix1[i, j] * scalar;
                }
            }
            return (matrix);
        }
        else
        {
            double[,] matrix = new double[,] {{-1}};
            return (matrix);
        }
    }
}

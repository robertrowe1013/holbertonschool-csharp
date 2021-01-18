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
            double[,] newMatrix = new double[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    newMatrix[i, j] = matrix[i, j] * scalar;
                }
            }
            return (newMatrix);
        }
        else if (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3)
        {
            double[,] newMatrix = new double[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    newMatrix[i, j] = matrix[i, j] * scalar;
                }
            }
            return (newMatrix);
        }
        else
        {
            double[,] newMatrix = new double[,] {{-1}};
            return (newMatrix);
        }
    }
}

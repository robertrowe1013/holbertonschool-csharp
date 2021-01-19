using System;

/// <summary>
///  matrix math
/// </summary>
class MatrixMath
{
    public static double[,] Transpose(double[,] matrix)
    {
        if (matrix.GetLength(0) == 0 && matrix.GetLength(1) == 0)
        {
            return (0);
        }
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        double[,] newMatrix = new double[cols, rows];
        for (int i = 0; i < cols; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                newMatrix[i][j] = matrix[j][i];
            }
        }
        return (newMatrix);
    }
}

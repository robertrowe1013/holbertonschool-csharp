using System;

/// <summary>
///  matrix math
/// </summary>
class MatrixMath
{
    public static double[,] Inverse2D(double[,] matrix)
    {
        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            double det = (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
            if (det == 0)
            {
                double[,] newMatrix = new double[,] {{-1}};
                return (newMatrix);
            }
            else
            {
                double[,] newMatrix = new double[,] {{0, 0}};
                newMatrix[0, 0] = Math.Round((1 / det) * matrix[1, 1], 2);
                newMatrix[0, 1] = Math.Round((1 / det) * matrix[1, 0] * -1, 2);
                newMatrix[1, 0] = Math.Round((1 / det) * matrix[0, 1] * -1, 2);
                newMatrix[1, 1] = Math.Round((1 / det) * matrix[0, 0], 2);
                return (newMatrix);
            }
        }
        else
        {
            double[,] newMatrix = new double[,] {{-1}};
            return (newMatrix);
        }
    }
}

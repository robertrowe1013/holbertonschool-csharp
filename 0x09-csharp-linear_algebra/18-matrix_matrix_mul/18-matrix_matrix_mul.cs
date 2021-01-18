using System;

/// <summary>
///  matrix math
/// </summary>
class MatrixMath
{
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1.GetLength(1) == matrix2.GetLength(0))
        {
            double[,] newMatrix = new double[matrix1.GetLength(0), matrix2.GetLength(1)];

            return (newMatrix);
        }
        else
        {
            double[,] newMatrix = new double[] {{-1}};
            return (newMatrix);
        }
    }
}

using System;

/// <summary>
///  matrix math
/// </summary>
class MatrixMath
{
    public static double Determinant(double[,] matrix)
    {
        double det = -1;
        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            det = (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
            return (Math.Round(det, 2));
        }
        else if (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3)
        {
            det = (((matrix[0, 0] * matrix[1, 1] * matrix[2, 2]) + (matrix[0, 1] * matrix[1, 2] * matrix[2, 0]) + (matrix[0, 2] * matrix[1, 0] * matrix[2, 1])) - ((matrix[0, 2] * matrix[1, 1] * matrix[2, 0]) - (matrix[0, 1] * matrix[1, 0] * matrix[2, 2]) - (matrix[0, 0] * matrix[1, 2] * matrix[2, 1])));
            return (Math.Round(det,2));
        }
        else
        {
            return (det);
        }
    }
}

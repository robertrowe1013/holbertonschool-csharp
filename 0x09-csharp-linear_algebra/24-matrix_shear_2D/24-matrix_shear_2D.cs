using System;

/// <summary>
///  matrix math
/// </summary>
class MatrixMath
{
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2 && (direction == 'x' || direction == 'y'))
        {
            double[,] newMatrix = new double[2, 2];
            if (direction == 'x')
            {
                newMatrix[0, 0] = matrix[0, 1] * factor + matrix[0, 0];
                newMatrix[1, 0] = matrix[1, 1] * factor + matrix[1, 0];
                newMatrix[0, 1] = matrix[0, 1];
                newMatrix[1, 1] = matrix[1, 1];
                return (newMatrix);
            }
            else
            {
                newMatrix[0, 1] = matrix[0, 0] * factor + matrix[0, 1];
                newMatrix[1, 1] = matrix[1, 0] * factor + matrix[1, 1];
                newMatrix[0, 0] = matrix[0, 0];
                newMatrix[1, 0] = matrix[1, 0];
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

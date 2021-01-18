﻿using System;

/// <summary>
///  matrix math
/// </summary>
class MatrixMath
{
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1.GetLength(0) == 2 && matrix2.GetLength(0) == 2 && matrix1.GetLength(1) == 2 && matrix2.GetLength(1) == 2)
        {
            double[,] matrix = new double[,] {{0, 0}, {0, 0}};
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    matrix[i][j] = matrix1[i][j] + matrix2[i][j];
                }
            }
            return (matrix);
        }
        else if (matrix1.GetLength(0) == 3 && matrix2.GetLength(0) == 3 && matrix1.GetLength(1) == 3 && matrix2.GetLength(1) == 3)
        {
            double[,] matrix = new double[,] {{0, 0, 0}, {0, 0, 0}, {0, 0, 0}};
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        matrix[i][j][k] = matrix1[i][j][k] + matrix2[i][j][k];
                    }
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

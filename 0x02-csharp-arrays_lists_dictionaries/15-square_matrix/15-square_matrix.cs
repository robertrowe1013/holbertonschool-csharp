using System;
using System.Collections.Generic;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int[,] newMatrix = new int[myMatrix.GetLength(0), myMatrix.GetLength(1)];
        int row;
        int col;
        for (row = 0; row < myMatrix.GetLength(0); row++)
        {
            for (col = 0; col < myMatrix.GetLength(1); col++)
            {
                newMatrix[row, col] = myMatrix[row, col] * myMatrix[row,col];
            }
        }
        return newMatrix;
    }
}

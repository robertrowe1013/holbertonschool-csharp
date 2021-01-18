﻿using System;

/// <summary>
///  Vector math
/// </summary>
class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        if (vector.Length == 2)
        {
            return (Math.Round(Math.Sqrt((Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2))), 2));
        }
        else if (vector.Length == 3)
        {
            return (Math.Round(Math.Sqrt((Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2) + Math.Pow(vector[2], 2))), 2));
        }
        else
        {
            return (-1);
        }
    }
}

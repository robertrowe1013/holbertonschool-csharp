using System;

/// <summary>
///  Vector math
/// </summary>
class VectorMath
{
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if (vector1.Length == 2 && vector2.Length == 2)
        {
            return (1);
        }
        else if (vector1.Length == 3 && vector2.Length == 3)
        {
            return (1);
        }
        else
        {
            return (-1);
        }
    }
}

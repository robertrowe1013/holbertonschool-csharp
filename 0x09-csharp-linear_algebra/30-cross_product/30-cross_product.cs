using System;

/// <summary>
///  matrix math
/// </summary>
class VectorMath
{
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length == 3 && vector2.Length == 3)
        {
            double[] v = new double[] {0, 0, 0};
            v[0] = (vector1[1] * vector2[2]) - (vector1[2] * vector2[1]);
            v[1] = (vector1[2] * vector2[0]) - (vector1[0] * vector2[2]);
            v[2] = (vector1[0] * vector2[1]) - (vector1[1] * vector2[0]);
            return (v);
        }
        else
        {
            double[] v = new double[] {-1};
            return (v);
        }
    }
}

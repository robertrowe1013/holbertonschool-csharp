using System;

/// <summary>
///  Vector math
/// </summary>
class VectorMath
{
    public static double[] Add(double[] vector1, double[] vector2)
    {
        double[] v = new double[] {-1};
        if (vector1.Length == 2 && vector2.Length == 2)
        {
            v[0] = vector1[0] + vector2[0];
            v[1] = vector1[1] + vector2[1];
            return (v);
        }
        else if (vector1.Length == 3 && vector2.Length == 3)
        {
            v[0] = vector1[0] + vector2[0];
            v[1] = vector1[1] + vector2[1];
            v[2] = vector1[2] + vector2[2];
            return (v);
        }
        else
        {
            return (v);
        }
    }
}

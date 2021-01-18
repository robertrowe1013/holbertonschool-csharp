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
            double[] v = new double[] {0, 0};
            v[0] = Math.Round((vector1[0] + vector2[0]), 2);
            v[1] = Math.Round((vector1[1] + vector2[1]), 2);
            return (v);
        }
        else if (vector1.Length == 3 && vector2.Length == 3)
        {
            double[] v = new double[] {0, 0, 0};
            v[0] = Math.Round((vector1[0] + vector2[0]), 2);
            v[1] = Math.Round((vector1[1] + vector2[1]), 2);
            v[2] = Math.Round((vector1[2] + vector2[2]), 2);
            return (v);
        }
        else
        {
            double[] v = new double[] {-1};
            return (v);
        }
    }
}

using System;

/// <summary>
///  Vector math
/// </summary>
class VectorMath
{
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector.Length == 2)
        {
            double[] v = new double[] {0, 0};
            v[0] = Math.Round((vector[0] * scalar), 2);
            v[1] = Math.Round((vector[1] * scalar), 2);
            return (v);
        }
        else if (vector.Length == 3)
        {
            double[] v = new double[] {0, 0, 0};
            v[0] = Math.Round((vector[0] * scalar), 2);
            v[1] = Math.Round((vector[1] * scalar), 2);
            v[2] = Math.Round((vector[2] * scalar), 2);
            return (v);
        }
        else
        {
            double[] v = new double[] {-1};
            return (v);
        }
    }
}

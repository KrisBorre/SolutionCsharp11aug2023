﻿namespace ConsoleNormaalVerdeling14sep2023
{
    /// <summary>
    /// Gauss distributie met behulp van het algorithme van Leva (1992)
    /// </summary>
    internal class NormaalVerdeling_Leva1992_14sep2023 : Random14sep2023
    {
        private double mu, sig;

        public NormaalVerdeling_Leva1992_14sep2023(double gemiddelde = 0, double variantie = 1, ulong zaadje = 5) : base(zaadje)
        {
            mu = gemiddelde;
            sig = variantie;
        }

        public double Afwijking()
        {
            double u, v, x, y, q;
            do
            {
                u = doub();
                v = 1.7156 * (doub() - 0.5);
                x = u - 0.449871;
                y = Math.Abs(v) + 0.386595;
                q = Math.Pow(x, 2) + y * (0.19600 * y - 0.25472 * x);
            } while (q > 0.27597 && (q > 0.27846 || Math.Pow(v, 2) > -4.0 * Math.Log(u) * Math.Pow(u, 2)));
            return mu + sig * v / u;
        }
    }
}

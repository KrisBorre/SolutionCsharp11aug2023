
namespace ConsoleNeo25aug2023
{
    // Numerical Recipes in C++

    internal class NormaalVerdeling25aug2023 : Random25aug2023
    {
        double mu, sig;

        public NormaalVerdeling25aug2023(double gemiddelde = 0, double variantie = 1, ulong zaadje = 5) : base(zaadje)
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
                q = Math.Sqrt(x) + y * (0.19600 * y - 0.25472 * x);
            } while (q > 0.27597 && (q > 0.27846 || Math.Sqrt(v) > -4.0 * Math.Log(u) * Math.Sqrt(u)));
            return mu + sig * v / u;
        }
    };

}

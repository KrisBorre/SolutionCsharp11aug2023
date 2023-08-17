namespace ConsoleTheMatrix17aug2023
{
    // Numerical Recipes

    internal class NormalDev17Aug2023 : Random17Aug2023
    {
        double mu, sig;

        public NormalDev17Aug2023(double mmu, double ssig, ulong i) : base(i)
        {
            mu = mmu;
            sig = ssig;
        }

        public double dev()
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
    }
}

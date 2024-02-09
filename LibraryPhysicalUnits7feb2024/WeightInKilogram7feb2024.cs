namespace LibraryPhysicalUnits7feb2024
{
    public class WeightInKilogram7feb2024 : IWeight7feb2024
    {
        private double m_WeightInKilogram;
        private double m_PrecisionInKilogram;

        public WeightInKilogram7feb2024(double weightInKilogram, double precisionInKilogram = 0)
        {
            m_WeightInKilogram = weightInKilogram;
            m_PrecisionInKilogram = precisionInKilogram;
        }

        public double GetInKilogram()
        {
            return m_WeightInKilogram;
        }

        public double GetInTon()
        {
            return WeightCalculation7feb2024.ConvertKilogramIntoTon(m_WeightInKilogram);
        }

        public double GetInPounds()
        {
            return WeightCalculation7feb2024.ConvertKilogramIntoPounds(m_WeightInKilogram);
        }

        public double GetPrecisionInKilogram()
        {
            return m_PrecisionInKilogram;
        }

        public IWeight7feb2024 MultiplyBy(double factor)
        {
            var result = new WeightInKilogram7feb2024(this.m_WeightInKilogram * factor);
            return result;
        }

        public static WeightInKilogram7feb2024 operator *(double factor, WeightInKilogram7feb2024 b)
        {
            var result = new WeightInKilogram7feb2024(factor * b.GetInKilogram());
            return result;
        }

        public static WeightInKilogram7feb2024 operator *(WeightInKilogram7feb2024 a, double factor)
        {
            var result = new WeightInKilogram7feb2024(a.GetInKilogram() * factor);
            return result;
        }

        public override string ToString()
        {
            return m_WeightInKilogram + " kg";
        }
    }
}

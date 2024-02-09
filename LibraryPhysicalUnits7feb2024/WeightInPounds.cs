namespace LibraryPhysicalUnits7feb2024
{
    public class WeightInPounds : IWeight7feb2024
    {
        private double m_WeightInPounds;
        private double m_PrecisionInPounds;

        public WeightInPounds(double weightInPounds, double precisionInPounds = 0)
        {
            m_WeightInPounds = weightInPounds;
            m_PrecisionInPounds = precisionInPounds;
        }

        public double GetInPounds()
        {
            return m_WeightInPounds;
        }

        public double GetInKilogram()
        {
            return WeightCalculation7feb2024.ConvertPoundsIntoKilogram(m_WeightInPounds);
        }

        public double GetInTon()
        {
            return WeightCalculation7feb2024.ConvertPoundsIntoTon(m_WeightInPounds);
        }

        public double GetPrecisionInPounds()
        {
            return m_PrecisionInPounds;
        }

        public double GetPrecisionInKilogram()
        {
            return WeightCalculation7feb2024.ConvertPoundsIntoKilogram(m_PrecisionInPounds);
        }

        public IWeight7feb2024 MultiplyBy(double factor)
        {
            var result = new WeightInPounds(this.m_WeightInPounds * factor);
            return result;
        }

        public static WeightInPounds operator *(double factor, WeightInPounds b)
        {
            var result = new WeightInPounds(factor * b.GetInPounds());
            return result;
        }

        public static WeightInPounds operator *(WeightInPounds a, double factor)
        {
            var result = new WeightInPounds(a.GetInPounds() * factor);
            return result;
        }

        public override string ToString()
        {
            return m_WeightInPounds + " lbs";
        }
    }
}

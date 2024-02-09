namespace LibraryPhysicalUnits7feb2024
{
    // https://en.wikipedia.org/wiki/Tonne
    // https://en.wikipedia.org/wiki/Ton
    public class WeightInTon7feb2024 : IWeight7feb2024
    {
        private double m_WeightInTon;
        private double m_PrecisionInTon;

        public WeightInTon7feb2024(double weightInTon, double accuracyInTon = 0)
        {
            m_WeightInTon = weightInTon;
            m_PrecisionInTon = accuracyInTon;
        }

        public double GetInTon()
        {
            return m_WeightInTon;
        }

        public double GetInKilogram()
        {
            return WeightCalculation7feb2024.ConvertTonIntoKilogram(m_WeightInTon);
        }

        public double GetInPounds()
        {
            return WeightCalculation7feb2024.ConvertTonIntoPounds(m_WeightInTon);
        }

        public double GetPrecisionInTon()
        {
            return m_PrecisionInTon;
        }

        public double GetPrecisionInKilogram()
        {
            return WeightCalculation7feb2024.ConvertTonIntoKilogram(m_PrecisionInTon);
        }

        public override string ToString()
        {
            return m_WeightInTon + " Ton";
        }

        public IWeight7feb2024 MultiplyBy(double factor)
        {
            WeightInTon7feb2024 result = new WeightInTon7feb2024(this.m_WeightInTon * factor);
            return result;
        }


    }
}

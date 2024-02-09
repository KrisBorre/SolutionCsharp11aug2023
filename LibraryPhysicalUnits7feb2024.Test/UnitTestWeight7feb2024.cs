namespace LibraryPhysicalUnits7feb2024.Test
{
    public class UnitTestWeight7feb2024
    {
        [Fact]
        public void Test1()
        {
            WeightInKilogram7feb2024 weightJohn = new WeightInKilogram7feb2024(80, 1);
            Assert.Equal(0.080, weightJohn.GetInTon());
            Assert.Equal(expected: 80, actual: weightJohn.GetInKilogram());
            Assert.Equal(expected: 176.37, actual: weightJohn.GetInPounds(), tolerance: 0.1);
        }

        [Fact]
        public void Test2()
        {
            IWeight7feb2024 weight = new WeightInKilogram7feb2024(10, 0);
            Assert.Equal(10, weight.GetInKilogram());
            Assert.Equal(expected: 0.01, actual: weight.GetInTon());
            Assert.Equal(expected: 22.046226, actual: weight.GetInPounds(), tolerance: 0.01);
        }

        [Fact]
        public void Test3()
        {
            WeightInKilogram7feb2024 weightInKilogram = new WeightInKilogram7feb2024(80, 1);

            IWeight7feb2024 weight1 = new WeightInKilogram7feb2024(60, 3);

            IWeight7feb2024 weight2 = new WeightInTon7feb2024(0.072, 0.01);

            WeightInKilogram7feb2024 totalWeight = WeightCalculation7feb2024.Add(weight1, weightInKilogram);

            Assert.Equal(expected: 140, actual: totalWeight.GetInKilogram());

            totalWeight = WeightCalculation7feb2024.Add(weight1, weight2);

            Assert.Equal(expected: 132, actual: totalWeight.GetInKilogram());
        }

        [Fact]
        public void Test4()
        {
            WeightInKilogram7feb2024 weightInKilogram = new WeightInKilogram7feb2024(80, 1);

            IWeight7feb2024 weight1 = new WeightInKilogram7feb2024(60, 3);

            IWeight7feb2024 weight2 = new WeightInTon7feb2024(0.072, 0.01);

            WeightInKilogram7feb2024 totalWeight = WeightCalculation7feb2024.Add(weightInKilogram, weight1);

            Assert.Equal(expected: 140, actual: totalWeight.GetInKilogram());

            Assert.Equal(expected: 0.14, actual: totalWeight.GetInTon());

            IWeight7feb2024 weight3 = WeightCalculation7feb2024.Add(weight2, weight1);

            Assert.Equal(expected: 132, actual: weight3.GetInKilogram());

            Assert.Equal(expected: 0.132, actual: weight3.GetInTon());
        }

        [Fact]
        public void Test5()
        {
            WeightInKilogram7feb2024 weightInKilogram = new WeightInKilogram7feb2024(20);
            var result = weightInKilogram.MultiplyBy(5);
            Assert.Equal(expected: 100, actual: result.GetInKilogram());
        }

        [Fact]
        public void Test6()
        {
            WeightInTon7feb2024 weightInTon = new WeightInTon7feb2024(20);
            var result = weightInTon.MultiplyBy(5);
            Assert.Equal(expected: 100, actual: result.GetInTon());
        }

        [Fact]
        public void Test7()
        {
            WeightInPounds weightInPounds = new WeightInPounds(20);
            var result = weightInPounds.MultiplyBy(5);
            Assert.Equal(expected: 100, actual: result.GetInPounds());
        }

        [Fact]
        public void Test8()
        {
            WeightInKilogram7feb2024 weightInKilogram = new WeightInKilogram7feb2024(20);
            var result = weightInKilogram * 5;
            Assert.Equal(expected: 100, actual: result.GetInKilogram());
        }

        [Fact]
        public void Test9()
        {
            WeightInKilogram7feb2024 weightInKilogram = new WeightInKilogram7feb2024(20);
            var result = 5 * weightInKilogram;
            Assert.Equal(expected: 100, actual: result.GetInKilogram());
        }
    }
}
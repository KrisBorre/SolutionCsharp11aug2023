using LibraryPhysicalUnits7feb2024;

namespace ConsoleArrays7feb2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Meer-dimensionale Arrays
            {
                IWeight7feb2024 weight1 = new WeightInKilogram7feb2024(1);

                Console.WriteLine(weight1);

                IWeight7feb2024[,] weights1 = {
                        {new WeightInTon7feb2024(1.1), new WeightInTon7feb2024(1.2), new WeightInTon7feb2024(1.3)},
                        {new WeightInTon7feb2024(4.1), new WeightInTon7feb2024(1.5), new WeightInTon7feb2024(3.3)},
                        {new WeightInTon7feb2024(0.1), new WeightInTon7feb2024(1.2), new WeightInTon7feb2024(0.3)}
                    };

                Console.WriteLine(weights1[2, 1]);

                int arrayRijen = weights1.GetLength(0);
                int arrayKolommen = weights1.GetLength(1);

                ITemperature[,,] temperatures = {
                    {
                        {new TemperatureInCelsius(3, 1),new TemperatureInCelsius(4, 1)}, {new TemperatureInCelsius(5, 1),new TemperatureInCelsius(4, 1)}
                    },
                    {
                        {new TemperatureInCelsius(12, 1),new TemperatureInCelsius(34, 1)}, {new TemperatureInCelsius(35, 1),new TemperatureInCelsius(24, 1)}
                    },
                    {
                        {new TemperatureInCelsius(-12, 1),new TemperatureInCelsius(27, 1)}, {new TemperatureInCelsius(3, 1),new TemperatureInCelsius(24, 1)}
                    },
                };

                Console.WriteLine(temperatures[2, 0, 1]);

                int arrayDimensions = temperatures.Rank;

                Console.ReadLine();

                /*
1 kg
1,2 Ton
27 C
                */
            }
            #endregion
        }
    }
}

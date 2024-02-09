using LibraryPhysicalUnits7feb2024;

namespace ConsolePlanet9feb2024
{
    internal class Program
    {
        private static void Calculate(WeightInPounds weightOnEarth)
        {
            const int numberOfPlanets = 9;
            string[] planet = new string[numberOfPlanets];
            double[] conversion = new double[numberOfPlanets];
            double[] weightOnThatPlanet = new double[numberOfPlanets];
            int j = 0; planet[j] = "Mercury"; conversion[j] = 0.38;
            j++; planet[j] = "Venus"; conversion[j] = 0.91;
            j++; planet[j] = "Earth"; conversion[j] = 1.00;
            j++; planet[j] = "Mars"; conversion[j] = 0.38;
            j++; planet[j] = "Jupiter"; conversion[j] = 2.34;
            j++; planet[j] = "Saturn"; conversion[j] = 1.06;
            j++; planet[j] = "Uranus"; conversion[j] = 0.92;
            j++; planet[j] = "Neptune"; conversion[j] = 1.19;
            j++; planet[j] = "Pluto"; conversion[j] = 0.06;

            for (int k = 0; k < numberOfPlanets; k++)
            {
                weightOnThatPlanet[k] = (conversion[k] * weightOnEarth).GetInPounds();
            }

            for (int k = 0; k < numberOfPlanets; k++)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                if (planet[k] == "Jupiter") Console.ForegroundColor = ConsoleColor.Red;
                if (planet[k] == "Pluto") Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Your weight on {planet[k]} is {weightOnThatPlanet[k]} lbs.");
            }
        }

        private static void Main(string[] args)
        {
            Console.SetWindowSize(180, 30);

            Console.WriteLine("Give your mass on Earth in lbs: ");
            string input = Console.ReadLine();
            if (double.TryParse(input, out double weightOnEarth))
            {
                var weightInPoundsOnEarth = new WeightInPounds(weightOnEarth);
                Calculate(weightInPoundsOnEarth);
            }

            Console.ForegroundColor = ConsoleColor.Gray;

            /*
Your weight on Mercury is 68,4 lbs.
Your weight on Venus is 163,8 lbs.
Your weight on Earth is 180 lbs.
Your weight on Mars is 68,4 lbs.
Your weight on Jupiter is 421,2 lbs.
Your weight on Saturn is 190,8 lbs.
Your weight on Uranus is 165,6 lbs.
Your weight on Neptune is 214,2 lbs.
Your weight on Pluto is 10,799999999999999 lbs.
            */

            Console.ReadLine();
        }
    }
}


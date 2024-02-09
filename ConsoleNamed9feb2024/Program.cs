using LibraryPhysicalUnits7feb2024;

namespace ConsoleNamed9feb2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome in the circle!");

            Console.WriteLine("Give the diameter of the circle:");
            string input = Console.ReadLine();
            if (double.TryParse(input, out double x))
            {
                var lengthInMeter = new LengthInMeter(x, 0);
                var result1 = CalculateRadius(diameter: lengthInMeter);
                Console.WriteLine($"If the diameter is equal to {lengthInMeter}, then the radius is equal to {result1}!");

                var result2 = CalculateCircumference(diameter: lengthInMeter);
                Console.WriteLine($"If the diameter is equal to {lengthInMeter}, then the circumference is equal to {result2}!");

                var resul3 = CalculateArea(diameter: lengthInMeter);
                Console.WriteLine($"If the diameter is equal to {lengthInMeter}, then the area is equal to {resul3}!");
            }

            Console.ReadLine();
        }

        static AreaInSquareMeter Square(LengthInMeter x)
        {
            return x * x;
        }

        static LengthInMeter CalculateRadius(LengthInMeter diameter)
        {
            return diameter / 2;
        }

        // https://en.wikipedia.org/wiki/Circumference
        static LengthInMeter CalculateCircumference(LengthInMeter diameter)
        {
            return 2 * Math.PI * CalculateRadius(diameter);
        }

        // https://en.wikipedia.org/wiki/Circle
        static AreaInSquareMeter CalculateArea(LengthInMeter diameter)
        {
            return Math.PI * Square(CalculateRadius(diameter));
        }
    }
}


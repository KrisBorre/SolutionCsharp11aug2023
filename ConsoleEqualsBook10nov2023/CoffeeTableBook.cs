namespace ConsoleEqualsBook10nov2023
{
    internal class CoffeeTableBook : Book10nov2023
    {
        private const double minimum = 35;
        private const double maximum = 100;

        override public double Price
        {
            set
            {
                if (value >= minimum && value <= maximum)
                {
                    price = value;
                }
                else
                {
                    Console.WriteLine($"Sorry, bij CoffeeTableBook kan de prijs enkel tussen {minimum} en {maximum} liggen");
                }
            }
        }
    }
}

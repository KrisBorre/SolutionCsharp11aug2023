namespace ConsoleEqualsBook10nov2023
{
    internal class TextBook : Book10nov2023
    {
        private const double minimum = 20;
        private const double maximum = 80;

        public int GradeLevel { get; set; }

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
                    Console.WriteLine($"Sorry, bij Textbook kan de prijs enkel tussen {minimum} en {maximum} liggen");
                }
            }
        }
    }
}

using LibraryPhysicalUnits7feb2024;

namespace ConsoleNamed8feb2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region BerekenStraal
            {
                Console.WriteLine("Welkom bij de straal van een cirkel.");
                string input = "";
                while (input != "stop" && input != "exit")
                {
                    Console.WriteLine("Geef de diameter (exit is stop)");
                    input = Console.ReadLine();
                    if (double.TryParse(input, out double x) && input != "stop" && input != "exit")
                    {
                        var lengthInMeter = new LengthInMeter(x, 0);
                        var resultaat = BerekenStraal(diameter: lengthInMeter);
                        Console.WriteLine($"Als de diameter gelijk is aan {x}, dan is de straal gelijk aan {resultaat}!");
                    }
                }
            }
            #endregion

            #region BerekenOmtrek
            {
                Console.WriteLine("Welkom bij de omtrek van een cirkel.");
                string input = "";
                while (input != "stop" && input != "exit")
                {
                    Console.WriteLine("Geef de diameter (exit is stop)");
                    input = Console.ReadLine();
                    if (double.TryParse(input, out double x) && input != "stop" && input != "exit")
                    {
                        var lengthInMeter = new LengthInMeter(x, 0);
                        var resultaat = BerekenOmtrek(diameter: lengthInMeter);
                        Console.WriteLine($"Als de diameter gelijk is aan {x}, dan is de omtrek van de cirkel gelijk aan {resultaat}!");
                    }
                }
            }
            #endregion

            #region BerekenOppervlakte
            {
                Console.WriteLine("Welkom bij de oppervlakte van een cirkel.");
                string input = "";
                while (input != "stop" && input != "exit")
                {
                    Console.WriteLine("Geef de diameter (exit is stop)");
                    input = Console.ReadLine();
                    if (double.TryParse(input, out double x) && input != "stop" && input != "exit")
                    {
                        var lengthInMeter = new LengthInMeter(x, 0);
                        var resultaat = BerekenOppervlakte(diameter: lengthInMeter);
                        Console.WriteLine($"Als de diameter van de cirkel gelijk is aan {x}, dan is de oppervlakte gelijk aan {resultaat}.");
                    }
                }
            }
            #endregion

            Console.ReadLine();
        }

        /// <summary>
        /// Methode Kwadraat die het kwadraat van een ingevoerd getal berekend ( het getal geef je mee als paramater).
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        static AreaInSquareMeter Kwadraat(LengthInMeter x)
        {
            return x * x;
        }


        /// <summary>
        /// Methode BerekenStraal die de straal van een cirkel kan berekenen waarvan je de diameter meegeeft (de diameter geef je mee als parameter).
        /// </summary>
        /// <param name="diameter"></param>
        /// <returns></returns>
        static LengthInMeter BerekenStraal(LengthInMeter diameter)
        {
            return diameter / 2;
        }


        /// <summary>
        /// omtrek van een cirkel
        /// </summary>
        /// <param name="diameter"></param>
        /// <returns></returns>
        static LengthInMeter BerekenOmtrek(LengthInMeter diameter)
        {
            return 2 * Math.PI * BerekenStraal(diameter);
        }


        /// <summary>
        /// oppervlakte van een cirkel
        /// </summary>
        /// <param name="diameter"></param>
        /// <returns></returns>
        static AreaInSquareMeter BerekenOppervlakte(LengthInMeter diameter)
        {
            return Math.PI * Kwadraat(BerekenStraal(diameter));
        }
    }
}

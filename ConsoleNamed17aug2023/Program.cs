internal class Program
{
    static void Main(string[] args)
    {
        #region Methoden met Named parameters

        Console.WriteLine("Armstrong getallen tussen 0 en 1000:");

        var stopwatch = System.Diagnostics.Stopwatch.StartNew();

        ToonArmstrongNummers(); // optionele of default parameter.
        stopwatch.Stop();
        double totaletijd = stopwatch.Elapsed.TotalSeconds;
        Console.WriteLine($"De computer tijd nodig voor deze berekening is {totaletijd} seconden.");

        Console.WriteLine();

        Console.WriteLine("De oneven getallen tussen 0 en 10:");
        ToonOnEvenNummers(); // optionele of default parameter.

        Console.WriteLine();

        int getal = 10;
        Console.WriteLine($"De Armstrong getallen tussen 0 en {getal}:");
        ToonArmstrongNummers(iGetal: getal); // named parameter.

        Console.WriteLine();


        #region Grootste
        {
            Console.WriteLine("Welkom bij de grootste.");
            string input = "";
            while (input != "stop" && input != "exit")
            {
                Console.WriteLine("Geef het eerste getal (exit is stop)");
                input = Console.ReadLine();
                if (Double.TryParse(input, out double getal1) && input != "stop" && input != "exit")
                {
                    Console.WriteLine("Geef het tweede getal (exit is stop)");
                    input = Console.ReadLine();
                    if (Double.TryParse(input, out double getal2) && input != "stop" && input != "exit")
                    {
                        double resultaat = GeefGrootste(getal2: getal2, getal1: getal1); // Named
                        Console.WriteLine($"De grootste waarde is {resultaat}.");
                    }
                }
            }
        }
        #endregion


        #region Kwadraat
        {
            Console.WriteLine("Welkom bij het kwadraat.");
            string input = "";
            while (input != "stop" && input != "exit")
            {
                Console.WriteLine("Geef een getal (exit is stop)");
                input = Console.ReadLine();
                if (Double.TryParse(input, out double x) && input != "stop" && input != "exit")
                {
                    double resultaat = Kwadraat(x: x);
                    Console.WriteLine($"Kwadraat van {x} is {resultaat}.");
                }
            }
        }
        #endregion


        #region BerekenStraal
        {
            Console.WriteLine("Welkom bij de straal van een cirkel.");
            string input = "";
            while (input != "stop" && input != "exit")
            {
                Console.WriteLine("Geef de diameter (exit is stop)");
                input = Console.ReadLine();
                if (Double.TryParse(input, out double x) && input != "stop" && input != "exit")
                {
                    double resultaat = BerekenStraal(diameter: x);
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
                if (Double.TryParse(input, out double x) && input != "stop" && input != "exit")
                {
                    double resultaat = BerekenOmtrek(diameter: x);
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
                if (Double.TryParse(input, out double x) && input != "stop" && input != "exit")
                {
                    double resultaat = BerekenOppervlakte(diameter: x);
                    Console.WriteLine($"Als de diameter van de cirkel gelijk is aan {x}, dan is de oppervlakte gelijk aan {resultaat}.");
                }
            }
        }
        #endregion


        #region IsEven
        {
            Console.WriteLine("Welkom bij even getallen.");
            string input = "";
            while (input != "stop" && input != "exit")
            {
                Console.WriteLine("Geef een getal (exit is stop)");
                input = Console.ReadLine();
                if (Double.TryParse(input, out double x) && input != "stop" && input != "exit")
                {
                    if (IsEven(getal: x)) Console.WriteLine($"{x} is even!");
                    else Console.WriteLine($"{x} is oneven!");
                }
            }
        }
        #endregion


        #region IsArmstrong
        {
            Console.WriteLine("Welkom bij Armstrong.");
            string sGetal;
            do
            {
                Console.WriteLine("Geef getal: (exit is stop)");
                sGetal = Console.ReadLine();
                int iGetal;

                while (!Int32.TryParse(sGetal, out iGetal) && sGetal != "stop" && sGetal != "exit")
                {
                    Console.WriteLine("Geef een natuurlijk getal, aub: (exit is stop)");
                    sGetal = Console.ReadLine();
                }

                if (sGetal != "stop" && sGetal != "exit")
                {
                    if (IsArmstrong(iGetal))
                    {
                        Console.WriteLine("Het ingevoerde getal is een Armstrong-nummer.");
                    }
                    else
                    {
                        Console.WriteLine("Het ingevoerde getal is NIET een Armstrong-nummer.");
                    }
                }
            } while (sGetal != "stop" && sGetal != "exit");
        }
        #endregion


        #region ToonOnEvenNummers
        {
            Console.WriteLine("Welkom bij de oneven getallen.");
            string sGetal;
            do
            {
                Console.WriteLine("Geef getal: (exit is stop)");
                sGetal = Console.ReadLine();
                int iGetal;

                while (!Int32.TryParse(sGetal, out iGetal) && sGetal != "stop" && sGetal != "exit")
                {
                    Console.WriteLine("Geef een natuurlijk getal, aub: (exit is stop)");
                    sGetal = Console.ReadLine();
                }

                if (sGetal != "stop" && sGetal != "exit")
                {
                    ToonOnEvenNummers(iGetal);
                }
            } while (sGetal != "stop" && sGetal != "exit");
        }
        #endregion

        #region ToonArmstrongNummers
        {
            Console.WriteLine("Welkom bij de Armstrong getallen.");
            string sGetal;
            do
            {
                Console.WriteLine("Geef getal: (exit is stop)");
                sGetal = Console.ReadLine();
                int iGetal;

                while (!Int32.TryParse(sGetal, out iGetal) && sGetal != "stop" && sGetal != "exit")
                {
                    Console.WriteLine("Geef een natuurlijk getal, aub: (exit is stop)");
                    sGetal = Console.ReadLine();
                }

                if (sGetal != "stop" && sGetal != "exit")
                {
                    ToonArmstrongNummers(iGetal);
                }
            } while (sGetal != "stop" && sGetal != "exit");
        }
        #endregion


        #endregion

    }

    /// <summary>
    /// Methode Kwadraat die het kwadraat van een ingevoerd getal berekend ( het getal geef je mee als paramater).
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    static double Kwadraat(double x)
    {
        return Math.Pow(x, 2);
    }

    /// <summary>
    /// Methode BerekenStraal die de straal van een cirkel kan berekenen waarvan je de diameter meegeeft (de diameter geef je mee als parameter).
    /// </summary>
    /// <param name="diameter"></param>
    /// <returns></returns>
    static double BerekenStraal(double diameter)
    {
        return diameter / 2;
    }

    /// <summary>
    /// omtrek van een cirkel
    /// </summary>
    /// <param name="diameter"></param>
    /// <returns></returns>
    static double BerekenOmtrek(double diameter)
    {
        return 2 * Math.PI * BerekenStraal(diameter);
    }

    /// <summary>
    /// oppervlakte van een cirkel
    /// </summary>
    /// <param name="diameter"></param>
    /// <returns></returns>
    static double BerekenOppervlakte(double diameter)
    {
        return Math.PI * Kwadraat(BerekenStraal(diameter));
    }

    /// <summary>
    /// Geeft de grootste van 2 getallen.
    /// </summary>
    /// <param name="getal1"></param>
    /// <param name="getal2"></param>
    /// <returns></returns>
    static double GeefGrootste(double getal1, double getal2)
    {
        return Math.Max(getal1, getal2);
    }

    /// <summary>
    /// Methode IsEven die bepaald of een getal even of oneven is (geeft een bool terug die true is indien even).
    /// </summary>
    /// <param name="getal"></param>
    /// <returns></returns>
    static bool IsEven(double getal)
    {
        bool result = false;
        if (getal % 2 == 0) result = true;
        return result;
    }

    /// <summary>
    /// Geeft true terug als iGetal een Armstrong getal is, anders false.
    /// </summary>
    /// <param name="iGetal"></param>
    /// <returns></returns>
    static bool IsArmstrong(int iGetal)
    {
        bool isArmstrong = false;
        int lengte = iGetal.ToString().Length;
        int oorspronkelijkGetal = iGetal;
        int result = 0;
        for (int i = lengte - 1; i >= 0; i--)
        {
            int power = (int)Math.Pow(10, i);
            int getal = iGetal / power;
            result += (int)Math.Pow(getal, lengte);
            iGetal -= getal * power;
        }

        if (oorspronkelijkGetal == result)
        {
            isArmstrong = true;
        }
        return isArmstrong;
    }

    /// <summary>
    /// Toont de oneven getallen kleiner of gelijk aan iGetal.
    /// </summary>
    /// <param name="iGetal"></param>
    static void ToonOnEvenNummers(int iGetal = 10)
    {
        for (int i = 1; i <= iGetal; i++)
        {
            if (!IsEven(i))
            {
                Console.WriteLine(i);
            }
        }
    }

    /// <summary>
    /// Toont de Armstrong getallen kleiner of gelijk aan iGetal.
    /// </summary>
    /// <param name="iGetal"></param>
    static void ToonArmstrongNummers(int iGetal = 10000)
    {
        for (int i = 1; i <= iGetal; i++)
        {
            if (IsArmstrong(i))
            {
                Console.WriteLine(i);
            }
        }
    }

}
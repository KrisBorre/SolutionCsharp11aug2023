internal class Program
{
    enum SoortGewicht { ErnstigeZwaarlijvigheid, Zwaarlijvig, Overgewicht, NormaalGewicht, OnderGewicht };

    private static void Main(string[] args)
    {
        ConsoleColor defaultForegroundColor = Console.ForegroundColor;
        ConsoleColor defaultBackgroundColor = Console.BackgroundColor;

        string input = "";
        while (input != "stop" && input != "exit")
        {
            // ingave met punt, zorgt ervoor dat punt wordt genegeerd.
            // Ingave van een komma getal, dient met een komma te gebeuren.
            Console.WriteLine("Hoeveel weeg je in kilogram ? (exit is stop)");
            input = Console.ReadLine();
            double mass;
            if (Double.TryParse(input, out mass) && input != "stop" && input != "exit")
            {
                Console.WriteLine("Hoe groot ben je in meter ? (exit is stop)");
                input = Console.ReadLine();
                double length;
                if (Double.TryParse(input, out length) && input != "stop" && input != "exit")
                {
                    if (length != 0)
                    {
                        double BMI = (mass / (length * length));
                        SoortGewicht soortGewicht;
                        // format met 2 cijfers na de komma.                            
                        Console.Write($"Je BMI bedraagt {BMI:F2}. ");
                        if (BMI < 18.5)
                        {
                            soortGewicht = SoortGewicht.OnderGewicht;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ondergewicht!");
                        }
                        else if (BMI >= 18.5 && BMI < 25)
                        {
                            soortGewicht = SoortGewicht.NormaalGewicht;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Normaal gewicht!");
                        }
                        else if (BMI >= 25 && BMI < 30)
                        {
                            soortGewicht = SoortGewicht.Overgewicht;
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Overgewicht! Je loopt niet echt een risico, maar je mag niet dikker worden!");
                        }
                        else if (BMI >= 30 && BMI < 40)
                        {
                            soortGewicht = SoortGewicht.Zwaarlijvig;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Zwaarlijvigheid (obesitas). Verhoogde kans op allerlei aandoeningen zoals diabetes, hartaandoeningen en rugklachten. Je zou 5 tot 10 kg moeten vermageren.");
                        }
                        else // (BMI >= 40)
                        {
                            soortGewicht = SoortGewicht.ErnstigeZwaarlijvigheid;
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("Ernstige zwaarlijvigheid. Je moet dringend vermageren want je gezondheid is in gevaar (of je hebt je lengte of gewicht in verkeerde eenheid ingevoerd).");
                        }
                    }
                }
            }
            Console.BackgroundColor = defaultBackgroundColor;
            Console.ForegroundColor = defaultForegroundColor;
        }

    }
}
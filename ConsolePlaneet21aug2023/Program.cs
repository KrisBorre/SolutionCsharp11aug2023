internal class Program
{
    private static void Bereken(double gewichtOpAarde)
    {
        const int aantalPlaneten = 9;
        string[] planeet = new string[aantalPlaneten];
        double[] omzetting = new double[aantalPlaneten];
        double[] gewichtOpDiePlaneet = new double[aantalPlaneten];
        int j = 0; planeet[j] = "Mercurius"; omzetting[j] = 0.38;
        j++; planeet[j] = "Venus"; omzetting[j] = 0.91;
        j++; planeet[j] = "Aarde"; omzetting[j] = 1.00;
        j++; planeet[j] = "Mars"; omzetting[j] = 0.38;
        j++; planeet[j] = "Jupiter"; omzetting[j] = 2.34;
        j++; planeet[j] = "Saturnus"; omzetting[j] = 1.06;
        j++; planeet[j] = "Uranus"; omzetting[j] = 0.92;
        j++; planeet[j] = "Neptunus"; omzetting[j] = 1.19;
        j++; planeet[j] = "Pluto"; omzetting[j] = 0.06;

        for (int k = 0; k < aantalPlaneten; k++)
        {
            gewichtOpDiePlaneet[k] = omzetting[k] * gewichtOpAarde;
        }

        for (int k = 0; k < aantalPlaneten; k++)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            if (planeet[k] == "Jupiter") Console.ForegroundColor = ConsoleColor.Red;
            if (planeet[k] == "Pluto") Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Je weegt op {planeet[k]} {gewichtOpDiePlaneet[k]} kg volgens mijn weegschaal.");
        }
    }

    private static void Main(string[] args)
    {
        Console.SetWindowSize(180, 30);

        Console.WriteLine("Je massa is overal dezelfde. Je gewicht daarentegen is afhankelijk van de zwaartekracht van de plek waar je bent. Zo is je gewicht veel groter op Jupiter dan op Mars.");
        Console.WriteLine("Geef je massa op Aarde in kilogram: ");
        string input = Console.ReadLine();
        if (double.TryParse(input, out double gewichtOpAarde))
        {
            Bereken(gewichtOpAarde);
        }

        /* Je weegt op Mercurius 31,768 kg volgens mijn weegschaal.
        Je weegt op Venus 76,076 kg volgens mijn weegschaal.
        Je weegt op Aarde 83,6 kg volgens mijn weegschaal.
        Je weegt op Mars 31,768 kg volgens mijn weegschaal.
        Je weegt op Jupiter 195,624 kg volgens mijn weegschaal.
        Je weegt op Saturnus 88,616 kg volgens mijn weegschaal.
        Je weegt op Uranus 76,912 kg volgens mijn weegschaal.
        Je weegt op Neptunus 99,484 kg volgens mijn weegschaal.
        Je weegt op Pluto 5,016 kg volgens mijn weegschaal.
        */
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("Kris Borremans: De fysische grootheid gewicht is een kracht en wordt uitgedrukt met de eenheid Newton.");
        Console.ReadLine();
    }
}
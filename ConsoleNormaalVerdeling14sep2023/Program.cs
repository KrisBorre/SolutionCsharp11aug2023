using ConsoleNormaalVerdeling14sep2023;

internal class Program
{
    static void HistogramBoxMuller(double variance = 1.0)
    {
        const int NPTS = 200000;
        const int N = 20, NOVER2 = N / 2, ISCAL = 400, LLEN = 180;
        int klim;
        ulong idum;
        unchecked
        {
            idum = (ulong)(-13);
        }
        double dd, x6;
        int[] dist = new int[N + 1];
        NormaalVerdeling_BoxMuller_14sep2023 gasdev = new NormaalVerdeling_BoxMuller_14sep2023(0.0, variance, idum);
        for (int j = 0; j <= N; j++) dist[j] = 0;

        for (int i = 0; i < NPTS; i++)
        {
            x6 = 0.025 * N * gasdev.Afwijking();
            int j = (int)(x6 > 0 ? x6 + 0.5 : x6 - 0.5);
            if ((j >= -NOVER2) && (j <= NOVER2)) ++dist[j + NOVER2];
        }
        Console.WriteLine($"Normally distributed deviate of {NPTS} points with variance={variance}");
        Console.WriteLine("     x      p(x)        graph:");
        Console.WriteLine();

        for (int j = 0; j <= N; j++)
        {
            dd = ((double)(dist[j])) / NPTS;
            klim = (int)(ISCAL * dd);
            if (klim > LLEN) klim = LLEN;
            string txt = "";
            for (int i = 0; i < klim; i++)
            {
                txt += '*';
            }
            Console.Write($"{j / (0.25 * N),8} {dd,9}     ");
            Console.WriteLine(txt);
        }
    }


    static void HistogramLeva1992(double variance = 1.0)
    {
        const int NPTS = 200000;
        const int N = 20, NOVER2 = N / 2, ISCAL = 400, LLEN = 180;
        int klim;
        ulong idum;
        unchecked
        {
            idum = (ulong)(-13);
        }
        double dd, x6;
        int[] dist = new int[N + 1];
        NormaalVerdeling_Leva1992_14sep2023 gasdev = new NormaalVerdeling_Leva1992_14sep2023(0.0, variance, idum);
        for (int j = 0; j <= N; j++) dist[j] = 0;

        for (int i = 0; i < NPTS; i++)
        {
            x6 = 0.025 * N * gasdev.Afwijking();
            int j = (int)(x6 > 0 ? x6 + 0.5 : x6 - 0.5);
            if ((j >= -NOVER2) && (j <= NOVER2)) ++dist[j + NOVER2];
        }
        Console.WriteLine($"Normally distributed deviate of {NPTS} points with variance={variance}");
        Console.WriteLine("     x      p(x)        graph:");
        Console.WriteLine();

        for (int j = 0; j <= N; j++)
        {
            dd = ((double)(dist[j])) / NPTS;
            klim = (int)(ISCAL * dd);
            if (klim > LLEN) klim = LLEN;
            string txt = "";
            for (int i = 0; i < klim; i++)
            {
                txt += '*';
            }
            Console.Write($"{j / (0.25 * N),8} {dd,9}     ");
            Console.WriteLine(txt);
        }
    }

    private static void Main(string[] args)
    {
        Console.SetWindowSize(180, 30);

        double variantie_smal = 2.0;
        double variantie_breed = 10.0;

        Console.WriteLine("Normaal verdeling door middel van de traditionele Box Muller methode:");

        Console.WriteLine("Een smalle Gauss distributie:\n");
        HistogramBoxMuller(variantie_smal);

        Console.Write("Druk op de enter toets om verder te gaan.");
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Een brede Gauss distributie:\n");
        HistogramBoxMuller(variantie_breed);

        Console.Write("Druk op de enter toets om verder te gaan.");
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Normaal verdeling met algorithme van Leva (1992):");

        Console.WriteLine("Een smalle Gauss distributie:\n");
        HistogramLeva1992(variantie_smal);

        Console.Write("Druk op de enter toets om verder te gaan.");
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Een brede Gauss distributie:\n");
        HistogramLeva1992(variantie_breed);

        Console.WriteLine("met vriendelijke groeten, Kris Borremans");
        Console.ReadLine();
    }
}
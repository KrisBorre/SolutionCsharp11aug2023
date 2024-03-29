﻿using ConsoleTheMatrix17aug2023;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welkom bij de film The Matrix.");

        var stopwatch = System.Diagnostics.Stopwatch.StartNew();

        //Console.SetBufferSize(90, 30); // gooit Exception op desktop computer

        int consoleWidth = 80;
        int consoleHeight = Console.LargestWindowHeight;
        
        Console.CursorVisible = false;
        Console.SetWindowSize(consoleWidth, consoleHeight);

        ConsoleColor defaultForegroundColor = Console.ForegroundColor;
        ConsoleColor defaultBackgroundColor = Console.BackgroundColor;

        long ticks = DateTime.Now.Ticks;
        ulong seed = (ulong)ticks;
        var rangen = new NormalDev17Aug2023(0, 1, seed);

        ConsoleColor[] consoleColors = { ConsoleColor.DarkMagenta, ConsoleColor.DarkBlue, ConsoleColor.DarkCyan, ConsoleColor.DarkGreen, ConsoleColor.DarkRed, ConsoleColor.Red, ConsoleColor.Blue };

        double radiusMax = Math.Sqrt(Math.Pow(consoleHeight, 2) + Math.Pow(consoleWidth, 2)); // 84

        for (ulong i = 0; i < 100_000_000_000; i++)
        {
            int j = Math.Abs((int)rangen.int32()) % consoleWidth;
            int k = Math.Abs((int)rangen.int32()) % consoleHeight;
            Console.SetCursorPosition(j, k);

            double radius = Math.Sqrt(Math.Pow(k + 1, 2) + Math.Pow(j + 1, 2));

            const int minimum1 = 62;
            const int maximum1 = 400;

            // Veel karakters in het begin
            // radius klein 2 -> scaleFactor gelijk aan een getal veel groter dan 300 -> 168 / 2  = 84 
            // radius groot 80 -> scaleFactor gelijk aan 2
            double scaleFactor1 = (2 * radiusMax) / radius;
            // in het begin veel vreemde cijfers dus shift is 150
            // radius klein 2 -> shift 150
            // radius groot 80 -> shift naar 200
            double shift1 = 148 + radius;
            double a1 = (scaleFactor1 * rangen.dev()) + shift1;
            int a5 = Math.Abs((int)a1);
            int bin1 = (a5 % (maximum1 - minimum1)) + minimum1;

            char teken = Convert.ToChar(bin1);

            const int minimum2 = 0;
            int maximum2 = consoleColors.Length;
            // Weinig kleuren in het begin
            // radius klein 2 -> scale factor 2
            // radius groot 80 -> scale factor 3
            double scaleFactor2 = radius / 40.0;
            // radius klein 2 -> shift initieel is 0
            // radius groot 80 -> shift naar 6
            double shift2 = (radius / 30.0) - 0.1;

            double b1 = (scaleFactor2 * rangen.dev()) + shift2;
            int b5 = Math.Abs((int)b1);
            int index = (b5 % (maximum2 - minimum2)) + minimum2; // binning

            Console.ForegroundColor = consoleColors[index];

            Console.Write(teken);

            Thread.Sleep(1); //dit getal is in milliseconden.
        }

        Console.BackgroundColor = defaultBackgroundColor;
        Console.ForegroundColor = defaultForegroundColor;

        stopwatch.Stop();
        double totaletijd = stopwatch.Elapsed.TotalSeconds;
        
        Console.SetCursorPosition(0, consoleHeight / 2);
        Console.WriteLine($"De computer tijd nodig voor deze berekening is {totaletijd} seconden.");

        Console.ReadLine();
    }
}
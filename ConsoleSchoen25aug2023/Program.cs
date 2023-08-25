internal class Program
{
    private static int BerekenPrijs(int aantal = 0, int aantalZonderKorting = int.MaxValue, int normalePrijs = 20, int kortingsPrijs = 10)
    {
        int totalePrijs;
        if (aantal <= aantalZonderKorting)
        {
            totalePrijs = normalePrijs * aantal;
        }
        else // aantal > aantalZonderKorting
        {
            totalePrijs = normalePrijs * aantalZonderKorting + kortingsPrijs * (aantal - aantalZonderKorting);
        }
        return totalePrijs;
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("Tot hoeveel schoenen geldt de korting niet?");
        int aantalZonderKorting = Convert.ToInt32(Console.ReadLine());
        if (aantalZonderKorting >= 0)
        {
            Console.WriteLine("Hoeveel paar schoenen wenst U te kopen?");
            int aantal1 = Convert.ToInt32(Console.ReadLine());
            if (aantal1 >= 0)
            {
                int totalePrijs = BerekenPrijs(aantal1, aantalZonderKorting);

                Console.WriteLine($"De totale prijs is {totalePrijs} euro.");
            }
        }
        ToonZomer();
        ToonWinter(10);

        Console.ReadLine();
    }

    private static void ToonZomer()
    {
        const int aantal2 = 3;
        Console.WriteLine($"Tijdens onze zomeracties heb je al {aantal2} paar sandalen voor {BerekenPrijs(aantal2, normalePrijs: 10)} euro.");
    }

    private static void ToonWinter(int aantal = 2)
    {
        Console.WriteLine($"Tijdens onze winteracties heb je al {aantal} paar bergschoenen voor {BerekenPrijs(normalePrijs: 40, aantal: aantal, kortingsPrijs: 30, aantalZonderKorting: 1)} euro. Hiermee kan je Everest beklimmen!");
    }


}
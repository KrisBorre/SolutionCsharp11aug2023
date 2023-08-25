internal class Program
{
    static void Main(string[] args)
    {
        Console.SetWindowSize(120, 30);

        int score = 0;

        Vraag1(ref score);

        Vraag2(ref score);

        Vraag3(ref score);

        Console.WriteLine(Environment.NewLine + $"Score: {score} op 6");

        Console.WriteLine(Environment.NewLine + "Kris Borremans");
        Console.ReadLine();
    }

    static void Vraag1(ref int score)
    {
        const string quote = "\"";
        Console.WriteLine("Vraag 1:");
        // https://www.sanfoundry.com/csharp-mcqs-switch-statements/
        Console.WriteLine("Wat is de output van volgende C# code:");

        string opgave1 = @"
      static void Main(string[] args)
      {
          int movie = 1;

          switch (movie << 2 + movie)
          {
          default: 
              Console.WriteLine(" + quote + "3 Idiots" + quote + @");
              break;
          case 4: 
              Console.WriteLine(" + quote + "Ghazini" + quote + @");
              break;
          case 5: 
              Console.WriteLine(" + quote + "Krishh" + quote + @");
              break;
          case 8: 
              Console.WriteLine(" + quote + "Race" + quote + @");
              break;
          }
      }";

        Console.WriteLine(opgave1);
        Console.WriteLine(Environment.NewLine + @"a) 3 Idiots
b) Ghazini
c) Race
d) Krishh");

        Console.WriteLine("Uw antwoord: ");
        string antwoord1 = Console.ReadLine();
        switch (antwoord1.ToLower())
        {
            case "a":
                Console.WriteLine("FOUT !");
                score += -1;
                break;
            case "b":
                Console.WriteLine("FOUT !");
                score += -1;
                break;
            case "c":
                Console.WriteLine("Correct!");
                score += 2;
                break;
            case "d":
                Console.WriteLine("FOUT !");
                score += -1;
                break;
            default:
                Console.WriteLine("Dit antwoord behoort niet tot de mogelijkheden.");
                score += -1;
                break;
        }

        Console.WriteLine(Environment.NewLine + "Druk op de enter toets voor volgende vraag.");
        Console.ReadLine();
        Console.Clear();
    }

    static void Vraag2(ref int score)
    {
        const string quote = "\"";
        Console.WriteLine("Vraag 2:");
        // https://www.sanfoundry.com/csharp-multiple-choice-questions-answers/
        Console.WriteLine("Wat is de output van volgende C# code:");

        string opgave2 = @"
     static void Main(string[] args)
     {
         byte varA = 10;
         byte varB = 20;
         long result = varA & varB;

         Console.WriteLine(" + quote + @"{0} AND {1} Result: {2}" + quote + @", varA, varB, result);

         varA = 10;
         varB = 10;
         result = varA & varB;

         Console.WriteLine(" + quote + @"{0} AND {1} Result: {2}" + quote + @", varA, varB, result);
     }
            ";

        Console.WriteLine(opgave2);
        Console.WriteLine(Environment.NewLine + @"a) 0, 20
b) 10, 10
c) 0, 10
d) 0, 0");

        Console.WriteLine("Uw antwoord: ");
        string antwoord2 = Console.ReadLine();
        switch (antwoord2.ToLower())
        {
            case "a":
                Console.WriteLine("FOUT !");
                score += -1;
                break;
            case "b":
                Console.WriteLine("FOUT !");
                score += -1;
                break;
            case "c":
                Console.WriteLine("Correct!");
                score += 2;
                break;
            case "d":
                Console.WriteLine("FOUT !");
                score += -1;
                break;
            default:
                Console.WriteLine("Dit antwoord behoort niet tot de mogelijkheden.");
                score += -1;
                break;
        }

        Console.WriteLine(Environment.NewLine + "Druk op de enter toets voor volgende vraag.");
        Console.ReadLine();
        Console.Clear();
    }

    static void Vraag3(ref int score)
    {
        Console.WriteLine("Vraag 3:");
        // https://www.sanfoundry.com/csharp-mcqs-fundamental-delegates/
        Console.WriteLine("To implement delegates, the necessary condition is?");

        Console.WriteLine(Environment.NewLine + @"a) class declaration
b) inheritance
c) runtime polymorphism
d) exceptions");

        Console.WriteLine("Uw antwoord: ");
        string antwoord3 = Console.ReadLine();
        switch (antwoord3.ToLower())
        {
            case "a":
                Console.WriteLine("Correct!");
                score += 2;
                break;
            case "b":
                Console.WriteLine("FOUT !");
                score += -1;
                break;
            case "c":
                Console.WriteLine("FOUT !");
                score += -1;
                break;
            case "d":
                Console.WriteLine("FOUT !");
                score += -1;
                break;
            default:
                Console.WriteLine("Dit antwoord behoort niet tot de mogelijkheden.");
                score += -1;
                break;
        }
    }

}
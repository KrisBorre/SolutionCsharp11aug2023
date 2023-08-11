internal class Program
{
    static void Main(string[] args)
    {
        #region Arrays Opwarmers
        {
            {
                Console.WriteLine("Array gevuld met de getallen 0 tot 10");
                int[] array1 = new int[11];
                for (int i = 0; i < array1.Length; i++)
                {
                    array1[i] = i;
                    if (i != 0) Console.Write(", ");
                    Console.Write(array1[i]);
                }
                Console.WriteLine();
            }

            {
                Console.WriteLine("Array gevuld met de getallen van 100 tot 1");
                int[] array2 = new int[100];
                for (int i = 0; i < array2.Length; i++)
                {
                    array2[i] = i + 1;
                }
                Array.Reverse(array2);
                for (int i = 0; i < array2.Length; i++)
                {
                    if (i != 0) Console.Write(", ");
                    Console.Write(array2[i]);
                }
                Console.WriteLine();
            }

            {
                Console.WriteLine("Array gevuld met de letters a tot z.");
                Console.WriteLine("kleine a is 97");
                Console.WriteLine("kleine z is 122");
                int minimum = 97;
                int maximum = 122;
                char[] array3 = new char[maximum - minimum + 1];
                Console.WriteLine($"Lengte van array is gelijk aan het aantal letters in het alphabet: {array3.Length}");
                int k = 0;
                for (int i = minimum; i <= maximum; i++)
                {
                    char teken = Convert.ToChar(i);
                    array3[k++] = teken;
                }
                for (int i = 0; i < array3.Length; i++)
                {
                    if (i != 0) Console.Write(", ");
                    Console.Write(array3[i]);
                }

                Console.WriteLine();

                Console.WriteLine("array3[0] + array3[1] + array3[2] geeft {0} en niet abc", array3[0] + array3[1] + array3[2]); // 294

                string s1 = "";
                for (int i = 0; i < 3; i++)
                {
                    s1 += array3[i];
                }
                Console.WriteLine(s1); // abc

                Console.WriteLine();
            }


            {
                Console.WriteLine("Maak een array gevuld met willekeurige getallen tussen 1 en 100 (de array is 20 lang)");
                Random g = new Random(6523);
                int[] array4 = new int[20];
                for (int i = 0; i < array4.Length; i++)
                {
                    array4[i] = g.Next(1, 100);
                    if (i != 0) Console.Write(", ");
                    Console.Write(array4[i]);
                }
                Console.WriteLine();
            }


            {
                Console.WriteLine("Maak een array gevuld met afwisselend true en false (de array is 30 lang)");
                bool[] array5 = new bool[30];
                for (int i = 0; i < array5.Length; i++)
                {
                    array5[i] = (i % 2 == 0);
                    if (i != 0) Console.Write(", ");
                    Console.Write(array5[i]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Druk op de enter toets om door te gaan. (exit is stop)");
            string input = Console.ReadLine();
            if (input == "exit" || input == "stop") Environment.Exit(0);

        }
        #endregion


        #region Meer-dimensionale Arrays
        {
            Console.WriteLine("... n-bij-m array om een matrix voor te stellen.");
            Console.WriteLine("Merk op dat we dus nu een 3 bij 3 array maken. Iedere rij bestaat uit 3 elementen.");
            string[,] books = {
        {"Macbeth", "Shakespeare", "ID12341"},
        {"Before I Get Old", "Dave Marsh", "ID234234"},
        {"Security+", "Mike Pastore", "ID3422134"}
    };

            int[,,] temperatures = {
    {
        {3,4}, {5,4}
    },
    {
        {12,34}, {35,24}
    },
    {
        {-12,27}, {3,24}
    },
};
            Console.WriteLine("Stel dat we uit de books-array bijvoorbeeld de auteur van het derde boek wensen te tonen dan kunnen we schrijven:");
            Console.WriteLine(books[2, 1]);
            Console.WriteLine("Dit zal Mike Pastore op het scherm zetten.");
            Console.WriteLine(temperatures[2, 0, 1]);
            Console.WriteLine("Zal 27 terug geven: we vragen van de laatste array ([2]), daarbinnenin de eerste array ([0]) en daarvan het tweede ([1]) element.");

            Console.WriteLine("Lengte van iedere dimensie in een n-dimensionale matrix.");
            Console.WriteLine("Indien je de lengte opvraagt van een meer-dimensionale array dan krijg je de som van iedere lengte van iedere dimensie. Onze books array zal bijvoorbeeld dus lengte 9 hebben. Je kan echter de lengte van iedere aparte dimensie te weten komen met de GetLength() methode die iedere array heeft. Als parameter geef je de dimensie mee waarvan je de lengte wenst.");

            int arrayRijen = books.GetLength(0);
            int arrayKolommen = books.GetLength(1);

            Console.WriteLine("Het aantal dimensies van een array wordt trouwens weergegeven door de rank eigenschap die ook iedere array heeft. Bijvoorbeeld:");

            int arrayDimensions = temperatures.Rank;
        }
        #endregion


        #region Array als return-type bij een methode
        {
            int[] array = MaakArray(10, 0);
        }
        #endregion

        #region ToonVeelvouden
        {
            //Array aanmaken
            int[] getallen = new int[100];

            //Array vullen
            VulArray(getallen);

            //Alle elementen met 3 vermenigvuldigen
            VermenigvuldigArray(getallen, 3);

            //Enkel veelvouden van 4 op het scherm tonen
            ToonVeelvouden(getallen, 4);
        }
        #endregion


        #region ToonArray
        {
            Console.WriteLine("Arrays worden altijd ‘by reference’ doorgegeven aan een methode. Dit heeft twee belangrijke gevolgen: Je hoeft het ref keyword niet mee te geven, dit gebeurt impliciet reeds. \nJe werkt steeds met de eigenlijke array, ook in de methode. Als je dus aanpassingen aan de array aanbrengt in de methode, dan zal dit ook gevolgen hebben op de array van de parent-methode (logisch: het gaat om dezelfde array).");
            Console.WriteLine("static void EenVoorbeeldMethode(int[] inArray)");
            int[] leeftijden = { 2, 5, 1, 6 };
            ToonArray(leeftijden);
        }
        #endregion

        #region Char array naar string
        {
            char[] arrayOfLetters = { 'h', 'a', 'l', 'l', 'o' };
            arrayOfLetters[2] = 'x';
            string word = new string(arrayOfLetters);
            Console.WriteLine(word);
            Console.WriteLine("De uitvoer van deze code zal zijn: haxlo.");
        }
        #endregion


        #region Manueel zoeken in arrays 2 Nullable
        {
            string[] products = { "apples", "pears", "melons" };
            double[] prices = { 3.3, 6.2, 2.9 };

            Console.WriteLine("Which price do you need?");
            string userchoice = Console.ReadLine();

            bool? found = false;
            int productIndex = -1;

            for (int i = 0; i < products.Length; i++)
            {
                if (products[i] == userchoice)
                {
                    found = true;
                    productIndex = i;
                }
            }

            if (found == true)
            {
                Console.WriteLine($"Price for {userchoice} is {prices[productIndex]}");
            }
            else
            {
                Console.WriteLine("Not found");
            }

            //if (found) // Compileert niet.
            //{
            //    Console.WriteLine($"Price for {userchoice} is {prices[productIndex]}");
            //}
            //else
            //{
            //    Console.WriteLine("Not found");
            //}

            Console.WriteLine(found);
        }
        #endregion

        #region Nullable
        {
            Console.WriteLine($"int? is {(IsNullable(typeof(int?)) ? "nullable" : "non nullable")} value type");
            Console.WriteLine($"int is {(IsNullable(typeof(int)) ? "nullable" : "non-nullable")} value type");

            bool IsNullable(Type type) => Nullable.GetUnderlyingType(type) != null;

            // Output:
            // int? is nullable value type
            // int is non-nullable value type
        }
        #endregion

        #region String naar char array
        {
            string origineleZin = "Ik ben Tom";
            char[] karakters = origineleZin.ToCharArray();
            karakters[8] = 'i';
            string nieuweZin = new string(karakters);
            Console.WriteLine(nieuweZin);
            Console.WriteLine("De uitvoer zal worden: Ik ben Tim.");
        }
        #endregion

        #region Performatere oplossing
        {
            string[] products = { "apples", "pears", "melons" };
            double[] prices = { 3.3, 6.2, 2.9 };

            Console.WriteLine("Which price do you need?");
            string userchoice = Console.ReadLine();

            bool found = false;
            int productIndex = -1;

            int counter = 0;
            while (counter < products.Length && userchoice != products[counter])
            {
                counter++;
            }

            if (counter != products.Length) //product found!
            {
                found = true;
                productIndex = counter;
            }

            if (found)
            {
                Console.WriteLine($"Price for {userchoice} is {prices[productIndex]}");
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
        #endregion

        #region Manueel zoeken in arrays 2
        {
            string[] products = { "apples", "pears", "melons" };
            double[] prices = { 3.3, 6.2, 2.9 };

            Console.WriteLine("Which price do you need?");
            string userchoice = Console.ReadLine();

            bool found = false;
            int productIndex = -1;

            for (int i = 0; i < products.Length; i++)
            {
                if (products[i] == userchoice)
                {
                    found = true;
                    productIndex = i;
                }
            }

            if (found == true)
            {
                Console.WriteLine($"Price for {userchoice} is {prices[productIndex]}");
            }
            else
            {
                Console.WriteLine("Not found");
            }

            if (found)
            {
                Console.WriteLine($"Price for {userchoice} is {prices[productIndex]}");
            }
            else
            {
                Console.WriteLine("Not found");
            }

            Console.WriteLine(found);
        }
        #endregion


        #region Manueel zoeken in arrays
        {
            Console.WriteLine("Manueel zoeken in arrays");
            int teZoekenGetal = 12;

            int[] getallen = { 5, 10, 12, 25, 16 };

            bool gevonden = false;
            int index = -1;

            for (int i = 0; i < getallen.Length; i++)
            {
                if (getallen[i] == teZoekenGetal)
                {
                    gevonden = true;
                    index = i;
                }
            }
            Console.WriteLine(gevonden);
        }
        #endregion

        #region Copy
        {
            int[] ar = { 1, 2, 3 };
            int[] bar = new int[ar.Length];
            Array.Copy(ar, bar, ar.Length);

            for (int i = 0; i < bar.Length; i++)
            {
                Console.WriteLine(bar[i]);
            }

            Array.Clear(ar, 0, ar.Length);

            for (int i = 0; i < ar.Length; i++)
            {
                Console.WriteLine(ar[i]);
            }

            for (int i = 0; i < bar.Length; i++)
            {
                Console.WriteLine(bar[i]);
            }

            Console.WriteLine();
        }
        #endregion

        #region BinarySearch
        {
            int[] rank = { 224, 34, 156, 1023, -6 };
            Array.Sort(rank);

            Console.WriteLine("What rank do you need?");
            int userchoice = Convert.ToInt32(Console.ReadLine());

            int index = Array.BinarySearch(rank, userchoice);
            if (index >= 0)
                Console.WriteLine($"{userchoice} found at index {index}");
            else
                Console.WriteLine("Not found");
        }
        #endregion

        #region Clear
        {
            string[] myColors = { "red", "green", "yellow", "orange", "blue" };

            Console.WriteLine("Een array volledig leegmaken (alle elementen op ‘null’ zetten) doe je met de Array.Clear-methode, als volgt:");
            Array.Clear(myColors, 1, 2);

            //Toon resultaat van sorteren
            for (int i = 0; i < myColors.Length; i++)
            {
                Console.WriteLine(myColors[i]);
            }

            Console.WriteLine();
        }
        #endregion


        #region Reverse
        {
            string[] myColors = { "red", "green", "yellow", "orange", "blue" };
            //Sorteer
            Array.Reverse(myColors);

            //Toon resultaat van sorteren
            for (int i = 0; i < myColors.Length; i++)
            {
                Console.WriteLine(myColors[i]);
            }
        }
        #endregion


        #region Sort
        {
            string[] myColors = { "red", "green", "yellow", "orange", "blue" };
            //Sorteer
            Array.Sort(myColors);

            //Toon resultaat van sorteren
            for (int i = 0; i < myColors.Length; i++)
            {
                Console.WriteLine(myColors[i]);
            }
        }
        #endregion

        #region Rank
        {
            int[] getallen = new int[100];
            Console.WriteLine($"Rank is {getallen.Rank}"); // 1
        }
        #endregion

        #region Array
        {
            //Array aanmaken
            int[] getallen = new int[100];

            //Array vullen
            for (int i = 0; i < getallen.Length; i++)
            {
                getallen[i] = i;
            }

            //Alle elementen met 3 vermenigvuldigen
            for (int i = 0; i < getallen.Length; i++)
            {
                getallen[i] *= 3;
            }

            //Enkel veelvouden van 4 op het scherm tonen
            for (int i = 0; i < getallen.Length; i++)
            {
                if (getallen[i] % 4 == 0)
                    Console.WriteLine(getallen[i]);
            }
            /*0
12
24
36
48
60
72
84
96
108
120
132
144
156
168
180
192
204
216
228
240
252
264
276
288*/
            Console.WriteLine($"Rank is {getallen.Rank}"); // 1
            Console.WriteLine($"Max is {getallen.Max()}"); // 297
            Console.WriteLine($"Min is {getallen.Min()}"); // 0
            Console.WriteLine($"Average is {getallen.Average()}"); // 148,5
            Console.WriteLine();
        }
        #endregion

        Console.ReadLine();
    }


    #region ToonArray
    static void ToonArray(int[] getalArray)
    {
        Console.WriteLine("Array output:");
        for (int i = 0; i < getalArray.Length; i++)
        {
            Console.WriteLine(getalArray[i]);
        }
    }
    #endregion

    #region ToonVeelvouden

    static void VulArray(int[] getalArray)
    {
        for (int i = 0; i < getalArray.Length; i++)
        {
            getalArray[i] = i;
        }
    }

    static void VermenigvuldigArray(int[] getalArray, int multiplier)
    {
        for (int i = 0; i < getalArray.Length; i++)
        {
            getalArray[i] = getalArray[i] * multiplier;
        }
    }

    static void ToonVeelvouden(int[] getalArray, int veelvoudenvan)
    {
        for (int i = 0; i < getalArray.Length; i++)
        {
            if (getalArray[i] % veelvoudenvan == 0)
                Console.WriteLine(getalArray[i]);
        }
    }

    #endregion


    static int[] MaakArray(int lengte, int beginwaarde)
    {
        int[] resultArray = new int[lengte];
        for (int i = 0; i < lengte; i++)
        {
            resultArray[i] = beginwaarde;
        }
        return resultArray;
    }

}
namespace ConsoleEqualsBook10nov2023
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welkom bij \"Books on C#\"!");

            Book10nov2023 book1 = new Book10nov2023();
            book1.Title = "C# 6 for Programmers";
            book1.Author = "Paul Deitel, Harvey Deitel";
            book1.Price = 21.43;
            book1.ISBN = 978013459;
            Console.WriteLine(book1);

            Book10nov2023 book2 = new TextBook();
            book2.Title = "Learn C# in One Day and Learn It Well: C# for Beginners with Hands-on Project";
            book2.Author = "Jamie Chan";
            book2.Price = 11.67;
            book2.ISBN = 1518800;
            // Sorry, bij Textbook kan de prijs enkel tussen 20 en 80 liggen
            // Learn C# in One Day and Learn It Well: C# for Beginners with Hands-on Project -
            // Jamie Chan(1518800) 0
            Console.WriteLine(book2);
            book2.Price = 21.99;

            Book10nov2023 book3 = new CoffeeTableBook();
            book3.Title = "Learning C# by Developing Games with Unity 2019: Code in C# and build 3D games with Unity";
            book3.Author = "Harrison Ferrone";
            book3.Price = 39.99;
            book3.ISBN = 17895320;
            Console.WriteLine(book3);

            TextBook book4 = new TextBook();
            book4.Title = "C# in Depth";
            book4.Author = "Jan Skeet";
            book4.Price = 34.99;
            book4.ISBN = 161729;
            Console.WriteLine(book4);

            CoffeeTableBook book5 = new CoffeeTableBook();
            book5.Title = "C# 8.0 and .NET Core 3.0 – Modern Cross-Platform Development: Build applications with C#, .NET Core, Entity Framework Core, ASP.NET Core, and ML.NET using Visual Studio Code";
            book5.Author = "Mark J. Price";
            book5.Price = 35.99;
            book5.ISBN = 1788478;
            Console.WriteLine(book5);

            CoffeeTableBook book6 = new CoffeeTableBook();
            book6.Price = 199.99;
            book6.Title = "Concurrency in C# Cookbook: Asynchronous, Parallel, and Multithreaded Programming";
            book6.Author = "Stephen Cleary";
            book6.ISBN = 1492054;
            // Sorry, bij CoffeeTableBook kan de prijs enkel tussen 35 en 100 liggen
            // Concurrency in C# Cookbook: Asynchronous, Parallel, and Multithreaded Programming
            // -Stephen Cleary(1492054) 0
            Console.WriteLine(book6);
            book6.Price = 99.99;

            Book10nov2023 omnibus1 = Book10nov2023.TelOp(book1, book2);
            omnibus1.ISBN = 3628471;
            Console.WriteLine(omnibus1);

            Book10nov2023 omnibus2 = Book10nov2023.TelOp(book2, book3);
            omnibus2.ISBN = 853;
            Console.WriteLine(omnibus2);

            Book10nov2023 omnibus3 = Book10nov2023.TelOp(book3, book4);
            omnibus3.ISBN = 73;
            Console.WriteLine(omnibus3);

            Book10nov2023 omnibus4 = Book10nov2023.TelOp(book4, book5);
            Console.WriteLine(omnibus4);
            omnibus4.ISBN = 03650;

            Book10nov2023 omnibus5 = Book10nov2023.TelOp(book5, book6);
            omnibus5.ISBN = 44;
            Console.WriteLine(omnibus5);

            Book10nov2023 omnibus6 = Book10nov2023.TelOp(book6, book1);
            omnibus6.ISBN = 95645;
            Console.WriteLine(omnibus6);

            //Omnibus van Paul Deitel, Harvey Deitel, Jamie Chan -Paul Deitel, Harvey Deitel
            // Jamie Chan(3628471) 21,71
            //Omnibus van Jamie Chan, Harrison Ferrone - Jamie Chan, Harrison Ferrone(853) 3
            //,990000000000002
            //Omnibus van Harrison Ferrone, Jan Skeet - Harrison Ferrone, Jan Skeet(73) 37,4

            //Omnibus van Jan Skeet, Mark J.Price - Jan Skeet, Mark J. Price(0) 35,49
            //Omnibus van Mark J. Price, Stephen Cleary -Mark J.Price, Stephen Cleary(44)
            //7,99
            //Omnibus van Stephen Cleary, Paul Deitel, Harvey Deitel -Stephen Cleary, Paul D
            //itel, Harvey Deitel(95645) 60,709999999999994

            TextBook book7 = new TextBook();
            book7.ISBN = 1492054;
            if (book6.Equals(book7))
            {
                Console.WriteLine("Hetzelfde boek.");
            }
            else
            {
                Console.WriteLine("Dit wordt NIET uitgevoerd.");
            }

            Book10nov2023 book8 = new Book10nov2023();
            book8.ISBN = 161729;
            if (book8.Equals(book4))
            {
                Console.WriteLine("Hetzelfde boek.");
            }
            else
            {
                Console.WriteLine("Dit wordt NIET uitgevoerd.");
            }


            if (book1.Equals(book4))
            {
                Console.WriteLine("Dit wordt NIET uitgevoerd.");
            }
            else
            {
                Console.WriteLine("Niet hetzelfde boek.");
            }


            if (book2.Equals(omnibus2))
            {
                Console.WriteLine("Dit wordt NIET uitgevoerd.");
            }
            else
            {
                Console.WriteLine("Niet hetzelfde boek.");
            }

            if (omnibus4.Equals(book3))
            {
                Console.WriteLine("Dit wordt NIET uitgevoerd.");
            }
            else
            {
                Console.WriteLine("Niet hetzelfde boek.");
            }

            if (book5.Equals(omnibus1))
            {
                Console.WriteLine("Dit wordt NIET uitgevoerd.");
            }
            else
            {
                Console.WriteLine("Niet hetzelfde boek.");
            }

            //if (book6 == book7) // compileert niet!
            //{
            //    Console.WriteLine("== Hetzelfde boek.");
            //}
            //else
            //{
            //    Console.WriteLine("== Dit wordt NIET uitgevoerd.");
            //}

            if (book8 == book4)
            {
                Console.WriteLine("== Hetzelfde boek. Dit wordt niet uitgevoerd.");
            }
            else
            {
                Console.WriteLine("Conclusie: == en Equals leveren verschillende resultaten.");
            }

            Book10nov2023 book9 = new Book10nov2023();
            book9.Title = "Life on the Edge: The Coming of Age of Quantum Biology";
            book9.Author = "Al-Khalili Jim; McF";
            book9.Price = 86;
            book9.ISBN = 552778079;
            Console.WriteLine(book9);

            Book10nov2023 book10 = new Book10nov2023();
            book10.Title = "C# 11 and .NET 7 - Modern Cross-Platform Development Fundamentals - Seventh Edition: Start building websites and services with ASP.NET Core 7, Blazor, and EF Core 7";
            book10.Author = "Mark J Price";
            book10.Price = 43;
            book10.ISBN = 1803237805;
            Console.WriteLine(book10);

            if (book9.Equals(book10))
            {
                Console.WriteLine("Dit wordt NIET uitgevoerd.");
            }
            else
            {
                Console.WriteLine("Niet hetzelfde boek.");
            }


            Console.ReadLine();
        }

    }
}


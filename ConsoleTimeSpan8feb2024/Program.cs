namespace ConsoleTimeSpan8feb2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://learn.microsoft.com/en-us/dotnet/api/system.timespan?view=net-8.0

            // Define two dates.
            DateTime date1 = new DateTime(2010, 1, 1, 8, 0, 15);
            DateTime date2 = new DateTime(2010, 8, 18, 13, 30, 30);

            // Calculate the interval between the two dates.
            TimeSpan interval = date2 - date1;
            Console.WriteLine("{0} - {1} = {2}", date2, date1, interval.ToString());

            // Display individual properties of the resulting TimeSpan object.
            Console.WriteLine("   {0,-35} {1,20}", "Value of Days Component:", interval.Days);
            Console.WriteLine("   {0,-35} {1,20}", "Total Number of Days:", interval.TotalDays);
            Console.WriteLine("   {0,-35} {1,20}", "Value of Hours Component:", interval.Hours);
            Console.WriteLine("   {0,-35} {1,20}", "Total Number of Hours:", interval.TotalHours);
            Console.WriteLine("   {0,-35} {1,20}", "Value of Minutes Component:", interval.Minutes);
            Console.WriteLine("   {0,-35} {1,20}", "Total Number of Minutes:", interval.TotalMinutes);
            Console.WriteLine("   {0,-35} {1,20:N0}", "Value of Seconds Component:", interval.Seconds);
            Console.WriteLine("   {0,-35} {1,20:N0}", "Total Number of Seconds:", interval.TotalSeconds);
            Console.WriteLine("   {0,-35} {1,20:N0}", "Value of Milliseconds Component:", interval.Milliseconds);
            Console.WriteLine("   {0,-35} {1,20:N0}", "Total Number of Milliseconds:", interval.TotalMilliseconds);
            Console.WriteLine("   {0,-35} {1,20:N0}", "Ticks:", interval.Ticks);

            /*
18/08/2010 13:30:30 - 1/01/2010 8:00:15 = 229.05:30:15
   Value of Days Component:                             229
   Total Number of Days:                 229,22934027777777
   Value of Hours Component:                              5
   Total Number of Hours:                 5501,504166666667
   Value of Minutes Component:                           30
   Total Number of Minutes:                       330090,25
   Value of Seconds Component:                           15
   Total Number of Seconds:                      19 805 415
   Value of Milliseconds Component:                       0
   Total Number of Milliseconds:             19 805 415 000
   Ticks:                               198 054 150 000 000
*/

            Console.ReadKey();
        }
    }
}

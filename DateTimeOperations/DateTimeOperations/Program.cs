namespace DateTimeOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            //Console.WriteLine(d);
            //Console.WriteLine("1) date: " + d.Date);
            //Console.WriteLine("2) day: " + d.Day);
            //Console.WriteLine("3) Day of week: " + d.DayOfWeek);
            //Console.WriteLine("4) Day of year: " + d.DayOfYear);
            //Console.WriteLine("5) Hour: " + d.Hour);
            //Console.WriteLine("6) Kind: " + d.Kind);
            //Console.WriteLine("7) Millisecond: " + d.Millisecond);
            //Console.WriteLine("8) Minute: " + d.Minute);
            //Console.WriteLine("9) Month: " + d.Month);
            //Console.WriteLine("10) Second: " + d.Second);
            //Console.WriteLine("11) Ticks: " + d.Ticks);
            //Console.WriteLine("12) Time of Day: " + d.TimeOfDay);
            //Console.WriteLine("13) Year: " + d.Year);

            //Console.WriteLine(d.ToLongDateString());
            //Console.WriteLine(d.ToLongTimeString());
            //Console.WriteLine(d.ToShortDateString());
            //Console.WriteLine(d.ToShortTimeString());
            //Console.WriteLine(d.ToString());
            //Console.WriteLine(d.ToString("yyyy-MM-dd HH:mm:ss"));
            //Console.WriteLine(d.ToString("yyyy-MM-dd HH:mm:ss.fff"));

            //DateTime d2 = d.AddHours(2);
            //DateTime d3 = d.AddMinutes(3);
            //DateTime d4 = d.AddDays(7);

            //Console.WriteLine(d);
            //Console.WriteLine(d2);
            //Console.WriteLine(d3);
            //Console.WriteLine(d4);

            DateTime d1 = new DateTime(2000, 10, 15);
            DateTime d2 = new DateTime(2000, 10, 18);

            TimeSpan t = d2.Subtract(d1);

            Console.WriteLine(t);


        }
    }
}
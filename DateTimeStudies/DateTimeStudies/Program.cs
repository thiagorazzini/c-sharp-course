using System.Globalization;

namespace DateTimeStudies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime dateTime = new DateTime(2023, 05, 02);
            //DateTime dateTime1 = new DateTime(2023, 05, 02, 11, 17, 03);
            //DateTime dateTime2 = new DateTime(2023, 05, 02, 11, 17, 03, 500);

            //DateTime dateTime3 = DateTime.Now;
            //DateTime dateTime4 = DateTime.Today;
            //DateTime dateTime5 = DateTime.UtcNow;


            //Console.WriteLine(dateTime);
            //Console.WriteLine(dateTime1);
            //Console.WriteLine(dateTime2);
            //Console.WriteLine(dateTime3);
            //Console.WriteLine(dateTime4);
            //Console.WriteLine(dateTime5);

            DateTime d1 = DateTime.Parse("2000-08-15");
            DateTime d2 = DateTime.Parse("2000-08-15 13:05:58");

            DateTime d3 = DateTime.Parse("15/08/2000");
            DateTime d4 = DateTime.Parse("15/08/2000 13:05:58");

            DateTime d5 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d6 = DateTime.ParseExact("10/08/2022 10:05:30", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);


        }
    }
}
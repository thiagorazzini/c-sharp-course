﻿namespace DateKindTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);

            //DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);

            //DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);

            //Console.WriteLine("d1: " + d1);
            //Console.WriteLine("d1 Kind: " + d1.Kind);
            //Console.WriteLine("d1: to Local " + d1.ToLocalTime());
            //Console.WriteLine("d1: to utc " + d1.ToUniversalTime());
            //Console.WriteLine();

            //Console.WriteLine("d2: " + d2);
            //Console.WriteLine("d2 Kind: " + d2.Kind);
            //Console.WriteLine("d2: to Local " + d2.ToLocalTime());
            //Console.WriteLine("d2: to utc " + d2.ToUniversalTime());
            //Console.WriteLine();


            //Console.WriteLine("d1: " + d3);
            //Console.WriteLine("d1 Kind: " + d3.Kind);
            //Console.WriteLine("d1: to Local " + d3.ToLocalTime());
            //Console.WriteLine("d1: to utc " + d3.ToUniversalTime());
            //Console.WriteLine();


            DateTime d1 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d2 = DateTime.Parse("2000-08-15T13:05:58Z");


            Console.WriteLine(d1);
            Console.WriteLine(d2);

            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 Kind: " + d1.Kind);
            Console.WriteLine("d1: to Local " + d1.ToLocalTime());
            Console.WriteLine("d1: to utc " + d1.ToUniversalTime());
            Console.WriteLine();

            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 Kind: " + d2.Kind);
            Console.WriteLine("d2: to Local " + d2.ToLocalTime());
            Console.WriteLine("d2: to utc " + d2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine(d2.ToString("yyy-MM-ddTHH:mm:ssZ"));
            Console.WriteLine(d2.ToUniversalTime().ToString("yyy-MM-ddTHH:mm:ssZ")); 



        }
    }
}
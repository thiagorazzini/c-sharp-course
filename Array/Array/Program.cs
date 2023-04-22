﻿using System.Globalization;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for( int i = 0; i < vect.Length; i++ )
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;

            for(int i = 0;i < vect.Length;i++)
            {
                sum += vect[i];
            }

            double avg = sum / vect.Length;

            Console.WriteLine($"AVERAGE HEIGHT = {avg.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
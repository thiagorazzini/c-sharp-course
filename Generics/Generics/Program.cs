﻿namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintService<string> printService = new PrintService<string>();


            Console.WriteLine("How many values? ");
            int n = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < n; i++)
            {
                string x = Console.ReadLine();
                
                printService.AddValue(x);
            }


            printService.Print();
            Console.WriteLine("First: " + printService.First());
        }
    }
}
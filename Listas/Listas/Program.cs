using System.Collections.Generic;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Jeovanna");
            list.Add("Luizinho");
            list.Add("Karol");
            list.Add("Jair");
            list.Insert(2, "Laercio");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("List count: " + list.Count);
            string s1 = list.Find(x => x[0] == 'J');
            string s2 = list.FindLast(x => x[0] == 'J');

            Console.WriteLine("First J: " + s1);
            Console.WriteLine("First J: " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'J');
            Console.WriteLine("First position 'J': " + pos1);
            
            int pos2 = list.FindLastIndex(x => x[0] == 'J');
            Console.WriteLine("First position 'J': " + pos2);

            Console.WriteLine("-------------------------------");
            List<string> list2 = list.FindAll(x => x.Length == 8);
            
            foreach(var item in list2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------------");

            //list.Remove("Jeovanna");

            list.RemoveRange(2, 2);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------------------");

            list.RemoveAll(x => x[0] == 'L');

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------------");
            list.RemoveAt(0);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }

    }
}
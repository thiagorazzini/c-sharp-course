namespace sortedSetStudies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> sortedSetA = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> sortedSetB = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            //union
            SortedSet<int> c = new SortedSet<int>(sortedSetA);
            c.UnionWith(sortedSetB);
            PrintCollection(c);

            //intersection
            SortedSet<int> d = new SortedSet<int>(sortedSetA);
            d.IntersectWith(sortedSetB);
            PrintCollection(d);
            //difference
            SortedSet<int> e = new SortedSet<int>(sortedSetA);
            e.ExceptWith(sortedSetB);
            PrintCollection(e);


        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
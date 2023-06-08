namespace HashAndSorted
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Laptop");
            set.Add("Tablet");


            Console.WriteLine(set.Contains("Laptop"));


            foreach(string p in set)
            {
                Console.WriteLine(p);
            }
        }
    }
}
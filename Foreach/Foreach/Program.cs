namespace Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Maria", "Alex", "Bob" };

            foreach (string v in vect)
            {
                Console.WriteLine(v);
            }
        }
    }
}
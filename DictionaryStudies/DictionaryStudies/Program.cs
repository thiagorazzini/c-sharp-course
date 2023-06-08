namespace DictionaryStudies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "19997546610";
            cookies["phone"] = "1934428763";


            Console.WriteLine(cookies["email"]);
            Console.WriteLine(cookies["phone"]);


            cookies.Remove("email");

            if(cookies.ContainsKey("email")) {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is no 'email' key");
            }

            Console.WriteLine("Size: " + cookies.Count);
            Console.WriteLine("ALL COOKIES: ");
            foreach(var item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

        }
    }
}
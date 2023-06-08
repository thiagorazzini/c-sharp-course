

namespace dictionaryConsolidation
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter file full path: ");
            string fullPath = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(fullPath))
                {
                    Dictionary<string, int> candidates = new Dictionary<string, int>();
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string candidateName = line[0];
                        int vote = int.Parse(line[1]);

                        if (candidates.ContainsKey(candidateName))
                        {
                            candidates[candidateName] += vote;
                        }
                        else
                        {
                            candidates[candidateName] = vote;
                        }


                    }
                    foreach (var item in candidates)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred during the execution");
                Console.WriteLine(e.Message);
            }
        }
    }
}
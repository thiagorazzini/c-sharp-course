using System.IO;
using System.Globalization;
using csvGenerate.Entities;

namespace csvGenerate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter full path name: ");
            string completePath = Console.ReadLine();

            try
            {
                string[] keepLines = File.ReadAllLines(completePath);

                string keepCompletePath = Path.GetDirectoryName(completePath); //aqui salvo o caminho do completePath
                string pathOut = keepCompletePath + @"\out";
                string outFileName = pathOut + @"\summary.csv";

                Directory.CreateDirectory(pathOut);
                using(StreamWriter sw = File.AppendText(outFileName))
                {
                    foreach(string line in keepLines)
                    {
                        string[] field = line.Split(',');
                        string name = field[0];
                        double price = double.Parse(field[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(field[2]);

                        Product p = new Product(name, price, quantity);

                        sw.WriteLine(p.Name + "," + p.Total().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }


            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred: ");
                Console.WriteLine(e.Message);
            }

        }
    }
}
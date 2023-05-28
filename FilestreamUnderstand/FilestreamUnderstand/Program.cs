using System.IO;

namespace FilestreamUnderstand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\labs\projects\udemy\arquivos\file1.txt";
            FileStream fs = null;
            StreamReader streamReader = null;

            try
            {
                fs = new FileStream(path, FileMode.Open);
                streamReader  = new StreamReader(fs);
                string line = streamReader.ReadLine();
                Console.WriteLine(line);
            }
            catch (IOException e)
            {

                Console.WriteLine("An error accurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if( streamReader != null ) streamReader.Close();
                if( fs != null ) fs.Close();
            }
        }
    }
}
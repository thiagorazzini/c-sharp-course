namespace BankProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o número da conta: ");
            
            Accout accout = new Accout();
            accout.SetName = Console.ReadLine();

        }
    }
}
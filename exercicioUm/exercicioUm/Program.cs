namespace exercicioUm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa primeira, segunda;
            
            primeira = new Pessoa();
            segunda = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");

            Console.Write("Nome: ");
            primeira.Name = Console.ReadLine();
            Console.Write("Idade: ");
            primeira.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");

            Console.Write("Nome: ");
            segunda.Name = Console.ReadLine();
            Console.Write("Idade: ");
            segunda.Age = int.Parse(Console.ReadLine());

            if(primeira.Age > segunda.Age)
            {
                Console.WriteLine($"Pessoa mais velha: {primeira.Name}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {segunda.Name}");
            }

        }
    }
}
namespace Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Students[] student = new Students[10];

            Console.Write("How many rooms will be rented? ");
            int quantityToRented = int.Parse(Console.ReadLine());


            for (int i = 1; i <= quantityToRented; i++)
            {

                Console.WriteLine($"Rent: #{i}");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int roomId = int.Parse(Console.ReadLine());
                student[roomId] = new Students(name, email);

            }

            Console.WriteLine("Busy rooms: ");
            for (int i  = 0; i < student.Length; i++)
            {
                if (student[i] != null)
                {
                 Console.WriteLine(i + ": " + student[i]);
                }
            }
        }
    }
}
namespace Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qtd = 10;
            Students room = new Students(qtd);


            Console.Write("How many rooms will be rented? ");
            int roomQtd = int.Parse(Console.ReadLine());

            int[] qtdRoom = new int[10];

            for(int i = 0; i < roomQtd ; i++)
            {
                Console.WriteLine($"Rent #{i+1}");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int roomId = int.Parse(Console.ReadLine());

                for(int  j = 0; j < qtdRoom.Length; j++)
                {
                    if(roomId == j)
                    {
                        qtdRoom[j] = roomId;
                        room = new Students(name, email, roomId[]);
                        Console.WriteLine(qtdRoom[j]);
                    }
                }


               



            }





        }
    }
}
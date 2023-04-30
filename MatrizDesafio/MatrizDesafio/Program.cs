namespace MatrizDesafio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] values = Console.ReadLine().Split(' ');

            int line = int.Parse(values[0]);
            int column = int.Parse(values[1]);

            int[,] matriz = new int[line, column];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                string[] toFill = Console.ReadLine().Split(' ');
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = int.Parse(toFill[j]);

                }
            }

            int theSearchedNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < matriz.GetLength(0); i++)
            {

                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] == theSearchedNumber)
                    {
                        Console.WriteLine($"Position: {i},{j}");
                        if (j > 0)
                        {
                            Console.WriteLine($"Left: {matriz[i, j - 1]}");
                        }
                        if (i > 0)
                        {
                            Console.WriteLine($"Up: {matriz[i - 1, j]}");
                        }
                        if(j < matriz.GetLength(1) - 1)
                        {
                            Console.WriteLine($"Right: {matriz[i,j+1]}");
                        }
                        if(i < matriz.GetLength(0) -1)
                        {
                            Console.WriteLine($"Down: {matriz[i+1, j]}");
                        }
                    }
                }

            }
        }



    }
}

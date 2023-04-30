namespace MatChallange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sizeMat = Console.ReadLine().Split(' ');

            int line = int.Parse(sizeMat[0]);
            int column = int.Parse(sizeMat[1]);


            int[,] mat = new int[line, column];




            for (int i = 0; i < line; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < values.Length; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }
            int searchNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (mat[i, j] == searchNumber)
                    {
                        Console.WriteLine($"Position{i},{j}");
                        if (j > 0)// 2 > 0 ?
                        {
                            
                            Console.WriteLine($"Left: {mat[i, j - 1]}");
                        }
                        if (i > 0)// i = 1 é maior que 0 ? sim, ele esta na segunda linha e nesse caso tem up
                        {
                            //então o topo é  1 - 1
                            // se fosse 2 seria 2 -1 e o topo seria na linha 1
                            
                            
                            Console.WriteLine($"Up: {mat[i - 1, j]}");

                        }
                        if (j < column - 1) // 1 é menor que 4 - 1 ? sim, 1 é menor que 3, se caso fosse 4 < 4 -1 
                        {
                            Console.WriteLine($"Right: {mat[i, j + 1]}");
                        }
                        if (i < line - 1)
                        {
                            Console.WriteLine($"Down: {mat[i + 1, j]}");
                        }

                    }

                }
            }




        }
    }
}
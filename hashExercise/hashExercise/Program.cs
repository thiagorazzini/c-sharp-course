namespace hashExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> CourseA = new HashSet<int>();
            HashSet<int> CourseB = new HashSet<int>();
            HashSet<int> CourseC = new HashSet<int>();


            Console.Write("How many students for course A ? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++) { 
                int qtdStudents = int.Parse(Console.ReadLine());
                CourseA.Add(qtdStudents);
            }

            Console.Write("How many students for course B ? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int qtdStudents = int.Parse(Console.ReadLine());
                CourseB.Add(qtdStudents);
            }

            Console.Write("How many students for course C ? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int qtdStudents = int.Parse(Console.ReadLine());
                CourseC.Add(qtdStudents);
            }

            HashSet<int> allStudents = new HashSet<int>(CourseA);
            allStudents.UnionWith(CourseB);
            allStudents.UnionWith(CourseC);
            Console.WriteLine("Total students: " + allStudents.Count);
            


        }
    }
}
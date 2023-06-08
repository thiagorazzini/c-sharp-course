namespace countCouseStudents
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
            for(int i = 1; i <= n; i++)
            {
                int codeCourse = int.Parse(Console.ReadLine());
                CourseA.Add(codeCourse);
            }

            Console.Write("How many students for course B ? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int codeCourse = int.Parse(Console.ReadLine());
                CourseB.Add(codeCourse);
            }

            Console.Write("How many students for course C ? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int codeCourse = int.Parse(Console.ReadLine());
                CourseC.Add(codeCourse);
            }

            HashSet<int> all = new HashSet<int>(CourseA);
            all.UnionWith(CourseB);
            all.UnionWith(CourseC);
            Console.WriteLine("Total Students: " + all.Count);
        }
    }
}
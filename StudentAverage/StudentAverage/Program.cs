using System.Globalization;
namespace StudentAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudantData student = new StudantData();

            Console.Write("Nome do aluno: ");
            student.Name = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
            student.GradesOne = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.GradesTwo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.GradesThree = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"NOTA FINAL = {student.gradesSum().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine(student.verifySituation());
            
        }
    }
}
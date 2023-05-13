using AbstractsMethods.Entities;
using AbstractsMethods.Entities.Enums;
using System.Globalization;
namespace AbstractsMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            Console.Write("Enter the number of shapes: ");
            int numberOfShapes = int.Parse(Console.ReadLine());
            
            for(int i =1; i <= numberOfShapes; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Retangle or Circle (r/c)? ");
                char typeShape = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (typeShape == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Rectangle(width, height, color));

                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Circle(radius, color));
                }

                

            }

            Console.WriteLine("SHAPE AREAS: ");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
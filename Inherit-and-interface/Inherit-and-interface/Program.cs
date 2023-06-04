using Inherit_and_interface.Model.Entities;
using Inherit_and_interface.Model.Enums;

namespace Inherit_and_interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle() {Radius = 2.0, Color = Color.White };
            IShape rectangle = new Retangle() {Width = 3.5, Height = 4.2, Color = Color.White };


            Console.WriteLine(circle);
            Console.WriteLine(rectangle);

        }
    }
}
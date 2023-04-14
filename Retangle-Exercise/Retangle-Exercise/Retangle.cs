using System;
using System.Globalization;

namespace Retangle_Exercise
{
    internal class Retangle
    {
        public double Width;
        public double Height;

        public double Area()
        {
            return Width * Height;
        }

        public double Perimeter()
        {
            return 2* Width + 2* Height;
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Width, 2) + Math.Pow(Height, 2));
        }

        public override string ToString()
        {
            return "AREA = "
                + Area().ToString("F2", CultureInfo.InvariantCulture)
                + "\n"
                + "PERÍMETRO = "
                + Perimeter().ToString("F2", CultureInfo.InvariantCulture)
                + "\n"
                + "DIAGONAL = "
                + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

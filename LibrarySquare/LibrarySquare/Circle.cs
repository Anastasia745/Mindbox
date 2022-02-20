using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySquare
{
    // Класс Круг
    public class Circle
    {
        public double radius; // радиус

        public Circle(double radius)
        {
            if (radius > 0)
                this.radius = radius;
            else
                Console.WriteLine("Радиус - положительное число");
        }

        // вычислить площадь
        public double getSquare()
        {
            double square = 3.14 * radius * radius;
            return square;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySquare
{
    // Класс Треуголник
    public class Triangle
    {
        public double a; // 1-я сторона
        public double b; // 2-я сторона
        public double c; // 3-я сторона

        public Triangle(double a, double b, double c)
        {
            if ((a > 0) && (b > 0) && (c > 0))
            {
                if ((a < b + c) || (b < a + c) || (c < b + a))
                {
                    this.a = a;
                    this.b = b;
                    this.c = c;
                }
                else
                    Console.WriteLine("Сумма двух сторон треугольника всегда больше третей");
            }
            else
                Console.WriteLine("Длины сторон треуголника - положительные числа");
        }

        // определить тип треугольника
        public string getType()
        {
            string type;
            if (a == b && b == c)
                type = "Равносторонний";
            else
            {
                if (a == b || b == c || a == c)
                {
                    type = "Равнобедренный";
                    if (isRight())
                        type = type + " прямоугольный";
                }
                else
                {
                    if (c * c == a * a + b * b)
                        type = "Прямоугольный";
                    else
                        type = "Обыкновенный";
                }
            }
            return type;
        }

        // вычислить периметр
        public double getPerimeter()
        {
            double perimeter = a + b + c;
            return perimeter;
        }

        // вычислить площадь
        public double getSquare()
        {
            double square = Math.Sqrt(getPerimeter() / 2 * (getPerimeter() / 2 - a) * (getPerimeter() / 2 - b) * (getPerimeter() / 2 - c));
            return square;
        }

        // определить, является ли треугольник прямоугольным
        public bool isRight()
        {
            bool is_right;
            if ((c * c == a * a + b * b) || (b * b == a * a + c * c) || (a * a == c * c + b * b))
                is_right = true;
            else
                is_right = false;
            return is_right;
        }
    }
}

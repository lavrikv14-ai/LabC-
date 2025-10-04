using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Program
    {
        // перевірка чи інснує трикутник 
        public static bool IsValidTriangle(double a, double b, double c)
        {
            return a > 0 && b > 0 && c > 0 &&
                a + b > c && a + c > b && b + c > a;
        }


        // Perimeter
        public static double GetPerimeter(double a, double b, double c)
        {
            return a + b + c;
        }

        // Площа за формулою Герона
        public static double GetArea(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        // Тип трикутника
        public static string GetTriangleType(double a, double b, double c)
        {
            if (a == b && b == c)

                return "рівносторонній";

            if (a == b || a == c || b == c)

                return "рівнобедрений";

            if (Math.Abs(a * a + b * b - c * c) < 0.0001 ||
                Math.Abs(a * a + c * c - b * b) < 0.0001 ||
                Math.Abs(b * b + c * c - a * a) < 0.0001)

                return "прямокутний";


            return "довільний";


        }
        public static void Main()
        {
            Console.Write("Введи a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введи b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Введи c: ");
            double c = double.Parse(Console.ReadLine());

            if (IsValidTriangle(a, b, c))
            {
                Console.WriteLine("Трикутник існує");
                Console.WriteLine("Периметр: " + GetPerimeter(a, b, c));
                Console.WriteLine("Площа: " + GetArea(a, b, c));
                Console.WriteLine("Тип: " + GetTriangleType(a, b, c));
            }
            else
            {
                Console.WriteLine("Трикутник не існує");
            }

        }

    }
}

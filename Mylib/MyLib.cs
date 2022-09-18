using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Net;

namespace Mylib
{
    public class MyLib
    {
        public static double b { get; private set; }

        public static void Square()
        {
            while (b <= 0)
            {
                Console.WriteLine("Чему равен радиус?");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Радиус не может быть отрицательным либо равным нулю");
            }
            double p = 3.14;
            double s = b * b * p;
            Console.WriteLine($"Площадь круга равна: {s}");
            
        }
        public static double z { get; private set; }
        public static double x { get; private set; }
        public static double c { get; private set; }
        public static void Triangle()
        {
            Console.WriteLine("Чему равна первая сторона треугольника?");
            z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Чему равна вторая сторона треугольника?");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Чему равна третья сторона треугольника?");
            c = Convert.ToDouble(Console.ReadLine());
            if (z+x<=c || x+c<=z || c + z <= x)
            {
                Console.WriteLine("Треугольника с такими сторонами существовать не может");
            }
            else
            {
                double p = (z + x + c) / 2;
                double s = Math.Sqrt(p * (p - z) * (p - x) * (p - c));
                Console.WriteLine(s);
            }
            
        }
    }
}

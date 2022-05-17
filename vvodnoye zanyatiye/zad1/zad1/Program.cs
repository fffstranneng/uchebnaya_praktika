using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите радиус R: ");
            double R = double.Parse(Console.ReadLine());
            Console.Write("Введите высту h: ");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Площадь поверхности цилиндра = {0}", 2 * Math.PI * R * (h + R));
            Console.ReadKey();
        }
    }
}
using System;
using static System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z6
{
    class Program
    {
        static void Main(string[] args)
        {
            //a = PI / 3;
            //b = 2 * PI / 3;
            //m = 20;
            Console.Write("Введите А: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите B: ");
            double b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите M: ");
            double m = Convert.ToInt32(Console.ReadLine());
            double h = (b - a) / Convert.ToDouble(m);
            Console.WriteLine("Шаг {0:f2}", h);
            while (a <= b)
            {
                Console.WriteLine("{0:f2}", Cos(a));
                a += h;
            }
        }
    }
}

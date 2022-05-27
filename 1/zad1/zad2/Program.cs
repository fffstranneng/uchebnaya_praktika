using System;
using static System.Math;
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
            Console.WriteLine("Введите значение х: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = 0;

            if (x == 1.3)
            {
                y = 3 * x - Pow(Cos(x), 2);
            }
            else if (x < 1.3)
            {
                y = PI * Pow(x, 2) - 7 / Sqrt(Abs(x));
            }
            Console.WriteLine("Значение y = " + y);
            Console.ReadKey(true);
        }
    }
}

using static System.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadd3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число х: ");
            var x = int.Parse(Console.ReadLine());

            var sin4x = Sin(4*x);
            var cos14x = 1 + Cos(4*x);

            var cos2x = Cos(2*x);
            var cos12x = 1 + Cos(2*x);

            var f1 = sin4x / cos14x;
            var f2 = cos2x / cos12x;

            var z1 = f1 * f2;
            Console.WriteLine("Число z1 = " + z1);

            Console.WriteLine("Введите число y: ");
            var y = int.Parse(Console.ReadLine());

            var z2 = 1 / Tan(3/2 * PI - y);
            Console.WriteLine("Число z2 = " + z2);
            Console.ReadKey(true);
        }
    }
}
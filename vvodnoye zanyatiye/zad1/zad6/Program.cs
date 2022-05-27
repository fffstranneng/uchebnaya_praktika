using static System.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z4
{
    class Program
    {
        static void Main(string[] args)
        {
            Double x = 5.2;
            Console.WriteLine("Заданный х равняется: " + x);

            var y1 = Pow(Sin(x), 2);
            var y2 = x * x + 5;
            var y3 = Pow(y2, 2);
            var y4 = Sqrt(x / 4);

            var y = (y1 * y3) - y4;
            Console.WriteLine("Результат вычислений: y = " + y);
            Console.ReadKey(true);
        }
    }
}

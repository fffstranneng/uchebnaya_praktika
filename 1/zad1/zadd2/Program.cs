using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            var x = Convert.ToInt32(Console.ReadLine());
            if (x % 2 == 0)
            {
                Console.WriteLine("Число х четное");
            }
            else if (x % 2 == 1)
            {
                Console.WriteLine("Число х нечетное");
            }
            Console.ReadKey(true);
        }
    }
}

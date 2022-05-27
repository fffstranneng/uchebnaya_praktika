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
            for (int i = 100; i <= 999; i++)
            {
                int schet = i;
                int one = schet / 100;
                schet %= 100;
                int two = schet / 10;
                schet %= 10;
                int three = schet / 1;
                schet %= 1;
                if ((one == two || two == three || three == one))
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey(true);
        }
    }
}

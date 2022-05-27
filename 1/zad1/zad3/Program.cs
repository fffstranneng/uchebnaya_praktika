using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите возраст молодого(?) человека: ");
            var x = Convert.ToInt32(Console.ReadLine());
            if (x < 1)
            {
                Console.WriteLine("Младенец");
            }
            else if ((x > 1) && (x < 12))
            {
                Console.WriteLine("Ребенок");
            }
            else if ((x >= 12) && (x < 16))
            {
                Console.WriteLine("Подросток");
            }
            else if ((x >= 16) && (x < 26))
            {
                Console.WriteLine("Юноша");
            }
            else if ((x >= 26) && (x < 71))
            {
                Console.WriteLine("Мужчина");
            }
            else if (x >= 71)
            {
                Console.WriteLine("Старик");
            }
            Console.ReadKey(true);
        }
    }
}

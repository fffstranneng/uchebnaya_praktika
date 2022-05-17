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
            int number = new Random().Next(100, 1000);
            string strNumber = number.ToString();
            char a = strNumber[strNumber.Length - 1];
            Console.WriteLine("Число: " + number);
            Console.WriteLine("Последняя цифра: " + a);
            char b = strNumber[strNumber.Length - 3];
            Console.WriteLine("Первая цифра: " + b);
            Console.ReadKey(true);
        }
    }
}
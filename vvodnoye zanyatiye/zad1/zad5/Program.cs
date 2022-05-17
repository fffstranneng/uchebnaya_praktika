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
            string s = "123";
            Console.WriteLine("Дано число: " + s);
            Console.WriteLine("Результат: " + s[2] + "" + s[1] + "" + s[0]);
            Console.ReadLine();
        }
    }
}
using System;
using System.Linq;

namespace z8
{ 
    class Program
    {
        public static void Main()
        {
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Enumerable.Range(1, n).Sum(x => n % x == 0 ? x : 0));
        }
    }
}
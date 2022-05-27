using System;
using System.Linq;

namespace z7
{ 
    class Program
    {
        public static void Main()
        {
            Console.WriteLine(String.Join(", ", Enumerable.Range(10, 90).Where(x => x == (x / 10) * (x % 10) * 3)));
        }
    }
}


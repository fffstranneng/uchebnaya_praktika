using System;
using System.Linq;

namespace z9
{
    class Program
    {
        public static void Main()
        { 
             for (int i = 1; i< 10; i++)
             for (int j = 0; j< 10; j++)
                { 
             if ((i* i + j* j) % 13 == 0) Console.WriteLine($"{i * 10 + j} - n");
                }
             Console.ReadKey(true);
        }
    }
}

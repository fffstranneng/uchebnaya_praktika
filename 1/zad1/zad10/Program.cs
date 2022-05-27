using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z10
{
    class Program
    {
        public static void Main()
        {
            int[] msv = new int[20];
            Random r = new Random();
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < msv.Length; i++)
            {
                msv[i] = r.Next(0, 10);
                Console.Write(msv[i] + " ");
            }
            var msv2 = msv.Where(n => n % 2 != 0);
            Console.WriteLine("\n\nПосле удаления четных:");
            foreach (int i in msv2)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
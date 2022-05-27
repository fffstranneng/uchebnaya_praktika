using System;
using static System.Math;

namespace z1
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.Write("Введите x: ");
                int x = Convert.ToInt32(Console.ReadLine());
                double y = 4 - ((x - 7) / (4 - x));
                if (Double.IsInfinity(y))
                {
                    Console.WriteLine("Бесконечность");
                }
                else
                {
                    Console.WriteLine(y);
                }

                double y1 = Sin(x) / (Pow(x, 3) - 1);
                if (Double.IsInfinity(y1))
                {
                    Console.WriteLine("Бесконечность");
                }
                else
                {
                    Console.WriteLine(y1);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Нужно ввести число");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Деление на ноль недопустимо!!!");
            }



        }
    }
}


using System;

namespace КОЗЛИК_В_ОГОРОД
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину стороны огорода");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длину веревки");
            double r = Convert.ToDouble(Console.ReadLine());
            double s = Math.PI * r * r;
            if (l < 2 * r)
            {
                double a = Math.Acos(l / 2 / r);
                s = 4 * (a * r * r - l / 2 * r * Math.Sin(a));
            }
            Console.WriteLine($"Коза съела {s} кв.м");
            Console.ReadKey();
        }
    }
}

using System;

namespace rjpkb_f_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Сторона ");
            int SideOfTheSquare = int.Parse(Console.ReadLine());
            SubroutineForSolvingTheAreaOfASquare(SideOfTheSquare);
        }
        private static void SubroutineForSolvingTheAreaOfASquare(int sideOfTheSquare)
        {
            int S = sideOfTheSquare * sideOfTheSquare;
           
            Console.WriteLine($"Площадь квадрата {S}");
            Console.WriteLine("Введите длину стороны квадрата");
           
            double a = Convert.ToDouble(Console.ReadLine());
            double s = (a * a - Math.PI * (Math.Pow(a / 2, 2))) / 2;
           
            Console.WriteLine("Площадь которая сьест коза полный квадрат: " + s);
            Console.ReadKey();
           
            double l, R, D;
            
            Console.WriteLine("\n");
          
            l = Convert.ToDouble(Console.ReadLine());
            R = l / (2 * 3.14);
            D = R * R;
            S = (int)(D * D / 2);
           
            Console.WriteLine("Прощядь которая сьест козлиха если верёвка будет на половину:{0}", Convert.ToString(S));
            Console.ReadKey();
        }
    }
}

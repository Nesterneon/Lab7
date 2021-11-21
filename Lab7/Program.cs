using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны 1-го треугольника");
            float a1 = Convert.ToInt32(Console.ReadLine());
            float b1 = Convert.ToInt32(Console.ReadLine());
            float c1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стороны 2-го треугольника");
            float a2 = Convert.ToInt32(Console.ReadLine());
            float b2 = Convert.ToInt32(Console.ReadLine());
            float c2 = Convert.ToInt32(Console.ReadLine());
            double p1, S1;
            double p2, S2;
            Gettriangle1(a1, b1, c1, out p1, out S1);
            Gettriangle2(a2, b2, c2, out p2, out S2);
            Console.WriteLine("Площадь 1-го треугольника");
            Console.WriteLine("{0:.00}", S1);
            Console.WriteLine("Площадь 2-го треугольника");
            Console.WriteLine("{0:.00}", S2);
            double Smax = 0;
            if (S1 > S2)
            {
                Smax = S1;
                Console.WriteLine("Большая площадь у 1 треугольника");
            }
            else if (S1 < S2)
            {
                Smax = S2;
                Console.WriteLine("Большая площадь у 2 треугольника");
            }
            Console.ReadKey();
        }
        static void Gettriangle1(float a1, float b1, float c1, out double p1, out double S1)
        {
            p1= (a1 + b1+ c1)/2;
            S1= Math.Sqrt(p1 * (p1 - a1) * (p1 - b1) * (p1 - c1));
        }
        static void Gettriangle2(float a2, float b2, float c2, out double p2, out double S2)
        {
            p2 = (a2 + b2+ c2) / 2;
            S2 = Math.Sqrt(p2 * (p2 - a2) * (p2 - b2) * (p2 - c2));
        }
    }
}

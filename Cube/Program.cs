using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину грани куба");
            float a = Convert.ToInt32(Console.ReadLine());
            double Sside, Scube, Vcube;
            Cube (a, out Sside, out Scube, out Vcube);
            Console.WriteLine("Площадь поверхности куба = {0:.00}", Scube);
            Console.WriteLine("Объем куба = {0:.00}", Vcube);
            Console.ReadKey();
        }
        static void Cube(float a, out double Sside, out double Scube, out double Vcube)
        {
            Sside = Math.Pow(a, 2);
            Scube = 6*Sside;
            Vcube = Math.Pow(a, 3);
        }
    }
}

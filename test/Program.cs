using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using geometric;


namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double circle = area.circle_area(4);
            double rectangular_triangle = area.triangle_area(3, 4, 5);
            double triangle = area.triangle_area(6.7, 7.9, 10.7);
            Console.WriteLine(circle);
            Console.WriteLine(rectangular_triangle);
            Console.WriteLine(triangle);
            Console.ReadLine();
        }
    }
}

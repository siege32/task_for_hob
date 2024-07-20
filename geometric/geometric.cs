using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace geometric
{
    public static class area
    {
        public const double PI = 3.1415926535897931;

        public static double circle_area(double radius)
        {
            return PI * Math.Pow(radius, 2);
        }

        public static double triangle_area(double first_side, double second_side, double third_side)
        {
            double[] sides = { first_side, second_side, third_side };

            double leg_first = sides.Min();
            double hypotinuse = sides.Max();
            double leg_second = sides.Sum() - leg_first - hypotinuse;

            if (Math.Pow(leg_first, 2) + Math.Pow(leg_second, 2) == Math.Pow(hypotinuse, 2))
            {
                return (leg_first * leg_second) / 2;
            }
            
            else
            {
                double perimeter = (sides[0] + sides[1] + sides[2]) / 2;

                return Math.Sqrt(perimeter * (perimeter - sides[0]) * (perimeter - sides[1]) * (perimeter - sides[2]));
            }
        }
    }
}

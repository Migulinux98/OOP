using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Triangle
{



    static double Area(double a, double bse, double b)
    {

        double area_t = 0.0;
        double m = bse / 2;
        if ((a <= m) && (b <= m))
        {
            return 0.0;
        }
        else
        {

            if (a == b)
            {
                if ((a == b) && (bse == b) && (bse == a))
                {
                    double h = 0.0;

                    Console.Write("Equilateral triangle :");
                    Console.Write("\n\n");

                    h = Math.Sqrt(3) * a / 2;
                    area_t = (bse * h) / 2;
                    return area_t;

                }
                else
                {

                    double h = 0.0;

                    Console.Write("Isosceles triangle :");
                    Console.Write("\n\n");

                    h = Math.Sqrt((Math.Pow(a, 2)) - ((Math.Pow(b, 2)) / 4));
                    area_t = (bse * h) / 2;
                    return area_t;
                }

            }
            else
            {
                Console.Write("Scalene triangle :");
                Console.Write("\n\n");

                double s = (a + b + bse) / 2;
                area_t = Math.Sqrt(s * (s - a) * (s - b) * (s - bse));
                return area_t;

            }
        }

    }
    static void Main()
    {

        double size_a, size_b, size_base;
        Console.WriteLine("Write the size of side a :");
        size_a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Write the size of side b:");
        size_b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Write the base size :");
        size_base = Convert.ToDouble(Console.ReadLine());


        double total = Area(size_a, size_b, size_base);

        if (total == 0)
        {
            Console.Write("This isnt a Triangle : {0}", total);
        }
        else
        {

            Console.Write("The area of this triangle is : {0}\n\n", total);

        }

    }
}
using System;
using System.Diagnostics;
using System.Linq.Expressions;

namespace experimental
{
    class findPerimeterandArea
    {
        static void findArea(double x, double y)
        {
            Console.WriteLine("The area of the circle: ");

            Console.WriteLine(x * x * y);
            
        }
        static void findPerimeter(double x, double y)
        {
            Console.WriteLine("The perimeter of the circle: ");

            Console.WriteLine(2 * x * y);
        }

        static void Main(string[] args)
        {
            double radius, pi;

            k1:  Console.WriteLine("Hello. Press P to calculate thecperimeter of a circle, press A to calculate the area of ​​a circle ");

            string x2 = Console.ReadLine();

            if (x2 == "A")
            {
                Console.WriteLine("Enter the value of radius: ");
                radius = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Enter the value of pi: ");
                pi = Convert.ToDouble(Console.ReadLine());

                findArea(radius, pi);
            }
            else if (x2 == "P")
            {
                Console.WriteLine("Enter the value of radius: ");
                radius = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Enter the value of pi: ");
                pi = Convert.ToDouble(Console.ReadLine());

                findPerimeter(radius, pi);

            }
            else {

                Console.WriteLine("Plase try again");
                goto k1;
                
            }


        }


    }
}

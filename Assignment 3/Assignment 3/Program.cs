using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    interface Shape
    {
        double Calculatearea();
        double Calculateperimeter();
    }

    class Circle :Shape
    {
        double radius { get; set; }
        static readonly double PI = 3.14;
        public double Calculatearea()
        {
            double area;
            Console.WriteLine("Enter the radius to calculate Area");
            radius = Convert.ToDouble(Console.ReadLine());
            area = radius * radius * PI;
            return area;
        }

        public double Calculateperimeter()
        {
            double perimeter;
            Console.WriteLine("Enter the radius to calculate Perimeter");
            radius = Convert.ToDouble(Console.ReadLine());
            perimeter = 2 * PI * radius;
            return perimeter;

        }
        
    }
    class Rectangle : Shape
    {
        double width { get; set; }
        double height { get; set; }
        public double Calculatearea()
        {
            double area;
            do
            {
                Console.WriteLine("Enter the width to calculate Area");
                width = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the height to calculate Area");
                height = Convert.ToDouble(Console.ReadLine());
                if(width <= 0 || height <= 0)
                {
                    Console.WriteLine("Error width and height cannot be negative or zero");
                }
            } while (width <= 0 || height <= 0);
            area = width * height;
            return area;
        }
        public double Calculateperimeter()
        {
            double perimeter;
            do {
                Console.WriteLine("Enter the width to calculate Perimeter");
                width = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the height to calculate Perimeter");
                height = Convert.ToDouble(Console.ReadLine());
                if (width <= 0 || height <= 0)
                {
                    Console.WriteLine("Error width and height cannot be negative or zero");
                }
            } while (width <= 0 || height <= 0);
            perimeter = 2 * (width * height);
            return perimeter;


        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            void exit()
            {
                Console.Clear();
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");
                Console.WriteLine("\t\t\t\t---------------------------------------------");
                Console.WriteLine("\t\t\t\t\t-THANK YOU FOR CHOOSING US!!!-");
                Console.WriteLine("\t\t\t\t---------------------------------------------\n");


            }


            int n;
            Console.WriteLine("\t\t\t\t---------------------------------------------");
            Console.WriteLine("\t\t\t\t  -WELCOME TO AREA AND PERIMETER CALCULATOR-");
            Console.WriteLine("\t\t\t\t---------------------------------------------\n");
            Console.WriteLine("\tWHAT DO YOU WANT TO CALCULATE TODAY??\n");
            Console.WriteLine("\t1.Area and Perimeter of a Circle");
            Console.WriteLine("\t2.Area and Perimeter of a Rectangle");
            Console.WriteLine("\t3.Exit\n");
            Console.WriteLine("Enter your choice");
            n=Convert.ToInt32(Console.ReadLine());

            if (n == 1)
            {
                Console.Clear();
                Circle circle = new Circle();
                int n1;
                Console.WriteLine("--------------------------------------------\n");
                Console.WriteLine("\tWHAT DO YOU WANT TO CALCULATE OF A CIRCLE\n");
                Console.WriteLine("\t1.Area");
                Console.WriteLine("\t2.Perimeter\n");
                Console.WriteLine("Enter your choice");
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\t\n");
                if (n1 == 1)
                {
                    Console.WriteLine("Area is "+circle.Calculatearea());
                    Console.ReadKey();

                }
                else
                {
                    Console.WriteLine("Perimeter is "+circle.Calculateperimeter());
                    Console.ReadKey();

                }
            }
            else if (n == 2)
            {
                Console.Clear();
                Rectangle rectangle = new Rectangle();
                int n2;
                Console.WriteLine("--------------------------------------------\n");
                Console.WriteLine("\tWHAT DO YOU WANT TO CALCULATE OF A RECTANGLE\n");
                Console.WriteLine("\t1.Area");
                Console.WriteLine("\t2.Perimeter\n");
                Console.WriteLine("Enter your choice");
                n2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\t\n");
                if (n2 == 1)
                {
                    Console.WriteLine("Area is "+rectangle.Calculatearea());
                    Console.ReadKey();

                }
                else
                {
                    Console.WriteLine("Perimeter is "+rectangle.Calculateperimeter());
                    Console.ReadKey();

                }
            
            }
            else if(n==3)
            {
                exit();
                Console.ReadKey();
            }
            
            
            







        }

    }
}

using System;
using Shapes.Entities.Enums;
using System.Collections.Generic;
using System.Globalization;
using Shapes.Entities;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            Console.Write("Enter the number of shapes: ");
            int n =  int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");

                Console.Write("Rectangle or Circle (r/c)? ");
                char result = char.Parse(Console.ReadLine());
                Console.Write("What's color (Black/Blue/Red)? ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (result == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Heigth: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    shapes.Add(new Rectangle(color, width, height));
                }
                else if(result == 'c')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Circle(color, radius));
                }
            }

            Console.WriteLine();
            Console.WriteLine("SHAPES AREAS: ");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}

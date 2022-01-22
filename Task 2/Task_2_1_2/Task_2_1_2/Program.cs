using System;
using System.Collections;
using System.Collections.Generic;

namespace Task_2_1_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Point first = new Point(1,2);
            Point second = new Point(1,4);
            Point third = new Point(22, -10);
            Point fourth = new Point(-4, 16);
            Rectangle test = new Rectangle(first, 2,3);
            Console.WriteLine(test.GetPerimeter);
            Console.WriteLine(test.GetArea);
            
            Circle one = new Circle(first, 3.5);
            Console.WriteLine(one.GetLineLength);
            Console.WriteLine(one.GetArea);
            Console.WriteLine(one.X);
            Console.WriteLine();
            Ring two = new Ring(first,3.5,2);
            Console.WriteLine(two.GetLineLength);
            Console.WriteLine(two.GetArea);
            Console.WriteLine(two.X);
            Console.WriteLine();
            Square test2 = new Square(second, 5);
            Console.WriteLine(test2.GetPerimeter);
            Console.WriteLine(test2.GetArea);
            Console.WriteLine();
            Line test3 = new Line(third, fourth);
            Console.WriteLine(test3.GetLineLength);
            Console.WriteLine();
            Triangle test4 = new Triangle(first, second, third);
            Console.WriteLine(test4.GetLine1Length);
            Console.WriteLine(test4.GetLine2Length);
            Console.WriteLine(test4.GetLine3Length);
            Console.WriteLine();
            Console.WriteLine(test4.GetPerimeter);
            Console.WriteLine(test4.GetArea);
            List <Shape> list = new List<Shape>();
            list.Add(test4);
            foreach (var item in list)
            {
                Console.WriteLine(item.GetName()); 
            }
        }
    }
}

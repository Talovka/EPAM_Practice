using System;

namespace Task_2_1_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Point first = new Point(1,2);
            Point second = new Point(1,4);
            Point third = new Point(3, 2);
            Point fourth = new Point(3, 4);
            Rectangle test = new Rectangle(first, second, third, fourth);
            Circle one = new Circle(first, 3.5);
            Console.WriteLine(one.GetPerimeter);
            Console.WriteLine(one.GetArea);
            Console.WriteLine(one.X);
            Ring two = new Ring(first,3.5,2);
            Console.WriteLine(two.GetInnerPerimeter);
            Console.WriteLine(two.GetRingArea);
            Console.WriteLine(two.X);
        }
    }
}

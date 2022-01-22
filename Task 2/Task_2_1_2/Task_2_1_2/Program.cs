using System;
using System.Collections;
using System.Collections.Generic;

namespace Task_2_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Shape> list = new List<Shape>();
            
            
            foreach (var item in list)
            {
                Console.WriteLine(item.GetName()); 
            }
        }
    }
}

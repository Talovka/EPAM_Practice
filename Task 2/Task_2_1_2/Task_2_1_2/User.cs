using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_1_2
{
    class User
    {
        private List<Shape> _shape;
        public string Name { get; set; }
        public User(string name) 
        {
            Name = name;
            _shape = new List<Shape>();
        }
        public void AddShape(Shape shape) 
        {
            _shape.Add(shape);
        }
    }
}

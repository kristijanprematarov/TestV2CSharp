using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Rectangle : Shape
    {
        private int _length;

        public int Length
        {
            get { return _length; }
            set { _length = value; }
        }

        private int _width;

        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public Rectangle(int length, int width, string color)
        {
            this._length = length;
            this._width = width;
            base.setColor(color);
        }

        public override double Area()
        {
            return (_length*_width)*(_length * _length + _width * _width);
        }

        public void DisplayArea()
        {
            Console.WriteLine("The color is:");
            Console.WriteLine(base.getColor());
            Console.WriteLine("Result of --> area of the rectangle*(a2 + b2)");
            Console.WriteLine(this.Area());
        }
    }
}

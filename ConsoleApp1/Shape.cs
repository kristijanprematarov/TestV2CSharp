using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public abstract class Shape
    {
        private string _color;

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public void setColor(string color)
        {
            this._color = color;
        }

        public string getColor()
        {
            return _color;
        }

        public abstract double Area();
    }
}

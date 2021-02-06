using System;

namespace ConsoleApp1
{
    public class ScreenText : IScreenText
    {
        private double x;

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        private double y;

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        private string _theText;

        public string TheText
        {
            get { return _theText; }
            set { _theText = value; }
        }

        public ScreenText(double x, double y, string theText)
        {
            this.x = x;
            this.y = y;
            _theText = theText;
        }

        public void Display()
        {
            Console.WriteLine("The X coordinate is: {0}", x);
            Console.WriteLine("The Y coordinate is: {0}", y);
            Console.WriteLine(_theText);
        }
    }
}

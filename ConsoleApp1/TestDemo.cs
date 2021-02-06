using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class TestDemo : ITestDemo
    {
        private readonly Rectangle rectangle;

        public TestDemo(Rectangle rectangle)
        {
            this.rectangle = rectangle;
        }
        public void MainMethod()
        {
            rectangle.DisplayArea();
        }
    }
}

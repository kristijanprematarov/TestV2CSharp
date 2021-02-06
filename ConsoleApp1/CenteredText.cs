using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class CenteredText : ScreenText
    {
        //IF 1 = full width, full height ---> 0.5 center
        public CenteredText(double y, string theText)
            :base(0.5,y,theText)
        {

        }

        public void SetX()
        {
            X = 0.5;
        }
    }
}

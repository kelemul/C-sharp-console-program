using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Another_1
    {
      public dynamic Add(int x,int y)
        {
            var sum = x + y;
            return sum;
        }

        public dynamic  Div(float x, float y)
        {
            var div = x / y;
            return div;
        }
        public dynamic  Diff(int x, int y)
        {
            var min = x - y;
            return min;
        }
    }
}

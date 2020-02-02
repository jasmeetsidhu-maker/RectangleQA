using System;
using System.Collections.Generic;
using System.Text;

namespace Rectangle
{
    class Rectangle
    {
        private int length;
        private int width;

        public Rectangle() 
        {
            length = 1;
            width = 1;
            
        }
        public Rectangle ( int length, int width)
        {
            this.length = length;
            this.width = width;
        }

    }
}

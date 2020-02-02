using System;
using System.Collections.Generic;
using System.Text;

namespace Rectangle
{
    public class Rectangle
    {
        // variable declare
        private int length;
        private int width;
        // default construtor 
        public Rectangle() 
        {
            length = 1;
            width = 1;
            
        }

        // non- constructor 
        public  Rectangle ( int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        //Six  Methods

        public int GetLength()
        {
            return length;
        }

        public int SetLength(int length)
        {
            return this.length = length;
        }



        public int GetWidth()
        {
            return width;
        }

        public int SetWidth(int width)
        {
            return this.width = width;
        }

        public int GetPerimeter()
        {
            return GetPerimeter();
        }


        public int GetArea()
        {
            return GetArea();
        }
    }
}

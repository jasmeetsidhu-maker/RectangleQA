
namespace Rectangle
{
    public  class Rectangle
    {
        // variable dec
        private int length;
        private int width;
        // default construtor 
        public Rectangle() 
        {
             length = 1;
             width = 1;
            
        }

      //Six  Methods for Rectangle class

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

        public int  SetWidth(int width)
        {
              return this.width = width;
        }

        // to get perimeter value

        public int GetPerimeter()
        {
            return 2 * (length + width);
        }

        // to get area value 

        public int GetArea()
        {
            return  width * length;
            
        }
        // non- constructor 
        public Rectangle(int length, int width)
        {
            this.length = length ;
            this.width  = width ;
        }

    }

}

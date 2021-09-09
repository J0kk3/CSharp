using System;

namespace GetAndSet
{
    class Box
    {
        //Member variables
        private int length;
        private int height;
        //private int width;
        private int volume;
        
        //Default getter and setter
        public int Width { get; set; }
        
        //getter and setter
        public int Heigth
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        
        public int Volume
        {
            get
            {
                return this.length * this.height * this.width;
            }
            /*set
            {
                this.volume = value;
            }*/
        }
        
        public Box (int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            Width = width;
        }
        
        public void SetLength (int length)
        {
            if (length < 0)
            {
                throw new Exception ("Length should be higher than 0");
            }
            this.length = length;
        }
        
        public int GetLength()
        {
            return this.length;
        }
        
        public int GetVolume()
        {
            return this.length * this.height * this.Width;
        }
        
        public int FrontSurface
        {
            get
            {
                return height * length;
            }
        }
        
        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0} and height is {1} and width is {2}, so the volume is {3}", 
                length, height, Width, volume = length*height*Width);
        }
    }
}
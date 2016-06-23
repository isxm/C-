namespace MobilePhones
{
    using System;

    // class that holds information about display characteristics: size and number of colors
    public class Display
    {
        //constants in case of null value
        private const int DefaultHeight = 180;
        private const int DefaultWidth = 120;
        private const int DefaultNumberOfColors = 16000000;

        //fields 
        private int height;                         //task1
        private int width;                          //task1
        private int numberOfColors;                 //task1

        // constructors 2
        public Display()
        {
            this.height = DefaultHeight;
            this.width = DefaultWidth;
            this.numberOfColors = DefaultNumberOfColors;
        }

        public Display(int InputHeight, int InputWidth, int InputNumberOfColors)
        {
            this.height = InputHeight;
            this.width = InputWidth;
            this.numberOfColors = InputNumberOfColors;
        }

        //Proparties task 5
        public int Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height must be bigger than 0");
                }
                this.height = value;
            }
        }

        public int Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width must be bigger than 0");
                }
                this.width = value;
            }
        }

        public int NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Number of colors must be bigger than 0");
                }
                this.numberOfColors = value;
            }
        }

        //looks like all done for this class :)

    }
}
